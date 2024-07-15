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

using BunnyApiClient;
using EdgeStorageApiClient;
using LoggingApiClient;
using StreamApiClient;

var rootCommand = new RootCommand();
rootCommand.Name = "bunny-sdk";
rootCommand.Description = "Bunny SDK CLI";
var accessKeyOption = new Option<string>(
    "--access-key", "The key used to authenticate with Bunny. Can also be passed through the BUNNY_ACCESS_KEY environment variable."
);
rootCommand.AddGlobalOption(accessKeyOption);

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
    .UseRequestAdapter(context =>
    {
      var accessKey = context.ParseResult.GetValueForOption(accessKeyOption) ?? Environment.GetEnvironmentVariable("BUNNY_ACCESS_KEY") ?? "";

      var authProvider = new ApiKeyAuthenticationProvider(accessKey, "AccessKey", ApiKeyAuthenticationProvider.KeyLocation.Header);
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
    }).RegisterCommonServices();

return await builder.Build().InvokeAsync(args);
