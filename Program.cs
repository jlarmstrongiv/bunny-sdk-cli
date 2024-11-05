using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;

using Tomlyn;

using BunnyApiClient;
using EdgeStorageApiClient;
using LoggingApiClient;
using StreamApiClient;

var rootCommand = new RootCommand
{
  Name = "bunny-sdk",
  Description = "Bunny SDK CLI"
};
var accessKeyOption = new Option<string>(
    "--access-key", "The key used to authenticate with Bunny. Can also be passed through the BUNNY_ACCESS_KEY environment variable. Overrides --profile."
);
var profileOption = new Option<string>(
    "--profile", "The name of the profile associated with the access key used to authenticate with Bunny. Can also be passed through the BUNNY_PROFILE environment variable."
);
var debugOption = new Option<bool>(
    "--debug", "Enable detailed error stacktrace. Intended for troubleshooting."
);
rootCommand.AddGlobalOption(accessKeyOption);
rootCommand.AddGlobalOption(profileOption);
rootCommand.AddGlobalOption(debugOption);


var bunnyApiCommand = new Command("bunny-api");
var bunnyApiCommandTemp = new global::BunnyApiClient.BunnyApiClient().BuildRootCommand();
foreach (var cmd in bunnyApiCommandTemp.Subcommands)
{
  bunnyApiCommand.AddCommand(cmd);
}
rootCommand.AddCommand(bunnyApiCommand);

var edgeStorageApiCommand = new Command("edge-storage-api");
var baseUrlOption = new Option<string>(
    "--base-url", "Edge storage api regional endpoints"
)
{
  IsRequired = true,
};
edgeStorageApiCommand.AddOption(baseUrlOption);
var edgeStorageApiCommandTemp = new global::EdgeStorageApiClient.EdgeStorageApiClient().BuildRootCommand();
foreach (var cmd in edgeStorageApiCommandTemp.Subcommands)
{
  edgeStorageApiCommand.AddCommand(cmd);
}
rootCommand.AddCommand(edgeStorageApiCommand);

var loggingApiCommand = new Command("logging-api");
var loggingApiCommandTemp = new global::LoggingApiClient.LoggingApiClient().BuildRootCommand();
foreach (var cmd in loggingApiCommandTemp.Subcommands)
{
  loggingApiCommand.AddCommand(cmd);
}
rootCommand.AddCommand(loggingApiCommand);

var streamApiCommand = new Command("stream-api");
var streamApiCommandTemp = new global::StreamApiClient.StreamApiClient().BuildRootCommand();
foreach (var cmd in streamApiCommandTemp.Subcommands)
{
  streamApiCommand.AddCommand(cmd);
}
rootCommand.AddCommand(streamApiCommand);

var builder = new CommandLineBuilder(rootCommand)
    .UseDefaults()
    .UseExceptionHandler((e, context) =>
    {
      var debugFlag = context.ParseResult.HasOption(debugOption) ? context.ParseResult.GetValueForOption(debugOption) : yn(Environment.GetEnvironmentVariable("BUNNY_DEBUG"));
      if (debugFlag)
      {
        // write the exception stacktrace
        // adapted from System.CommandLine.Builder.CommandLineBuilderExtensions.UseExceptionHandler internal Default handler
        if (e is not OperationCanceledException)
        {
          outputColorizedErrorIfSupported(() =>
          {
            Console.Error.Write(context.LocalizationResources.ExceptionHandlerHeader());
            Console.Error.WriteLine(e.ToString());
          });

          return;
        }
      }

      if (e is ApiException httpException)
      {
        // output http status errors as "$code $reason" if possible
        if (Enum.TryParse(httpException.ResponseStatusCode.ToString(), out System.Net.HttpStatusCode httpStatus))
        {
          var _httpResponse = new HttpResponseMessage(httpStatus);
          if (!string.IsNullOrEmpty(_httpResponse.ReasonPhrase))
          {
            outputColorizedErrorIfSupported(() =>
            {
              Console.WriteLine($"{httpException.ResponseStatusCode} {_httpResponse.ReasonPhrase}");
            });
            return;
          }
        }
      }
      // catch-all, just write the short exception message
      outputColorizedErrorIfSupported(() =>
      {
        Console.WriteLine(e.Message);
      });
    }, 1)
    .UseRequestAdapter(context =>
    {
      if (context.ParseResult.Errors.Count > 0)
      {
        // there was a command parsing error, no need to continue so exit early with a fake adapter
        return new HttpClientRequestAdapter(new ApiKeyAuthenticationProvider("invalid", "accesskey", ApiKeyAuthenticationProvider.KeyLocation.Header));
      }
      var accessKey = context.ParseResult.GetValueForOption(accessKeyOption) ?? Environment.GetEnvironmentVariable("BUNNY_ACCESS_KEY") ?? "";
      var profile = context.ParseResult.GetValueForOption(profileOption) ?? Environment.GetEnvironmentVariable("BUNNY_PROFILE") ?? "";
      var profileFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".bunny", "credentials");
      var hasAccessKeyFlag = !string.IsNullOrEmpty(accessKey);
      var hasProfileFlag = !string.IsNullOrEmpty(profile);
      // access key (from any option source) overrides profile
      // if not provided, fallback to profile
      if (!hasAccessKeyFlag)
      {
        if (File.Exists(profileFilePath))
        {
          using StreamReader reader = File.OpenText(profileFilePath);
          var profiles = Toml.ToModel<Dictionary<string, ProfileEntry>>(
            reader.ReadToEnd(),
            options: new TomlModelOptions
            {
              // the default converts the file to pascal case
              // instead, tell it to do no conversion
              ConvertPropertyName = s => s,
            });
          ProfileEntry? profileEntry = null;
          if (!hasProfileFlag && profiles.Count == 1)
          {
            // the user did not specify a profile and there is only 1 profile available, select it
            profileEntry = profiles.First()!.Value;
          }
          else if (hasProfileFlag)
          {
            // the user specified a profile, profileEntry will be non-null if it exists
            if (!profiles.TryGetValue(profile, out profileEntry))
            {
              // the user specified a profile so error because the profile does not exist
              throw new Exception($"A profile named '{profile}' does not exist in the shared credentials file.");
            }
          }
          // profileEntry is null only when there is more than 1 profile available
          if (profileEntry != null)
          {
            accessKey = profileEntry.accessKey;
          }
        }
        else if (hasProfileFlag)
        {
          // the user specified a profile so error because the file does not exist
          throw new Exception($"The shared credentials file does not exist at {profileFilePath}. Have you run 'bunny-launcher login' or 'bunny-sync login' first?");
        }
        // otherwise, the user specified neither access key nor profile,
        // continue and let the handlers deal with the error
      }

      if (string.IsNullOrEmpty(accessKey))
      {
        throw new Exception("Missing access key. Please pass --access-key or --profile.");
      }

      var authProvider = new ApiKeyAuthenticationProvider(accessKey, "accesskey", ApiKeyAuthenticationProvider.KeyLocation.Header);
      var adapter = new HttpClientRequestAdapter(authProvider);
      var currentCommand = context.ParseResult.CommandResult;
      if (currentCommand.FindResultFor(bunnyApiCommand) != null)
      {
        adapter.BaseUrl = "https://api.bunny.net";
      }
      else if (currentCommand.FindResultFor(edgeStorageApiCommand) != null)
      {
        adapter.BaseUrl = context.ParseResult.GetValueForOption(baseUrlOption);
      }
      else if (currentCommand.FindResultFor(loggingApiCommand) != null)
      {
        adapter.BaseUrl = "https://logging.bunnycdn.com";
      }
      else if (currentCommand.FindResultFor(streamApiCommand) != null)
      {
        adapter.BaseUrl = "https://video.bunnycdn.com";
      }
      else
      {
        // could be root command, let it flow up to handle errors
      }

      // Register default serializers
      ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
      ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
      ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();

      // Register default deserializers
      ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
      ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
      ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();

      return adapter;
    })
    .RegisterCommonServices();

return await builder.Build().InvokeAsync(args);

static bool yn(string? s)
{
  if (string.IsNullOrEmpty(s)) return false;
  s = s.Trim().ToLower();
  return s == "y" || s == "yes" || s == "true" || s == "1" || s == "on";
}

static void outputColorizedErrorIfSupported(Action func)
{
  // adapted from System.CommandLine internal ConsoleHelpers
  // https://github.com/dotnet/command-line-api/blob/9ebcd90a3e2c80c0385aa24432a50d18f7f768b9/src/System.CommandLine/ConsoleHelpers.cs#L12-L21
  var colorsAreSupported = !(OperatingSystem.IsBrowser() || OperatingSystem.IsAndroid() || OperatingSystem.IsIOS() || OperatingSystem.IsTvOS()) && !Console.IsOutputRedirected;
  if (colorsAreSupported)
  {
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
  }
  func();
  if (colorsAreSupported)
  {
    Console.ResetColor();
  }
}

class ProfileEntry
{
  public ProfileEntry()
  {
    accessKey = "";
    email = "";
    id = "";
    name = "";
  }

#pragma warning disable IDE1006 // Naming Styles
  public string accessKey { get; set; }
  public string email { get; set; }
  public string id { get; set; }
  public string? name { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
