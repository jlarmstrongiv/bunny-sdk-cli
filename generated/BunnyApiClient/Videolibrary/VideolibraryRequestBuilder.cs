// <auto-generated/>
using BunnyApiClient.Models.StreamVideoLibrary;
using BunnyApiClient.Videolibrary.Item;
using BunnyApiClient.Videolibrary.Languages;
using BunnyApiClient.Videolibrary.ResetApiKey;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Videolibrary
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary
    /// </summary>
    public class VideolibraryRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the BunnyApiClient.videolibrary.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildAddAllowedReferrerNavCommand());
            commands.Add(builder.BuildAddBlockedReferrerNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            executables.Add(builder.BuildPostCommand());
            commands.Add(builder.BuildRemoveAllowedReferrerNavCommand());
            commands.Add(builder.BuildRemoveBlockedReferrerNavCommand());
            commands.Add(builder.BuildResetApiKeyByIdNavCommand());
            commands.Add(builder.BuildWatermarkNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// [AddVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_add)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "[AddVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_add)";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Videolibrary.VideolibraryPostRequestBody>(global::BunnyApiClient.Videolibrary.VideolibraryPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The languages property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLanguagesNavCommand()
        {
            var command = new Command("languages");
            command.Description = "The languages property";
            var builder = new global::BunnyApiClient.Videolibrary.Languages.LanguagesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// [ListVideoLibraries API Docs](https://docs.bunny.net/reference/videolibrarypublic_index)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "[ListVideoLibraries API Docs](https://docs.bunny.net/reference/videolibrarypublic_index)";
            var pageOption = new Option<int?>("--page") {
            };
            pageOption.IsRequired = true;
            command.AddOption(pageOption);
            var perPageOption = new Option<int?>("--per-page") {
            };
            perPageOption.IsRequired = true;
            command.AddOption(perPageOption);
            var searchOption = new Option<string>("--search", description: "The search term that will be used to filter the results") {
            };
            searchOption.IsRequired = true;
            command.AddOption(searchOption);
            var includeAccessKeyOption = new Option<bool?>("--include-access-key") {
            };
            includeAccessKeyOption.IsRequired = true;
            command.AddOption(includeAccessKeyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var page = invocationContext.ParseResult.GetValueForOption(pageOption);
                var perPage = invocationContext.ParseResult.GetValueForOption(perPageOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var includeAccessKey = invocationContext.ParseResult.GetValueForOption(includeAccessKeyOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Page = page;
                    q.QueryParameters.PerPage = perPage;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    q.QueryParameters.IncludeAccessKey = includeAccessKey;
                });
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The resetApiKey property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResetApiKeyNavCommand()
        {
            var command = new Command("reset-api-key");
            command.Description = "The resetApiKey property";
            var builder = new global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Videolibrary.VideolibraryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public VideolibraryRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/videolibrary?includeAccessKey={includeAccessKey}&page={page}&perPage={perPage}&search={search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Videolibrary.VideolibraryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VideolibraryRequestBuilder(string rawUrl) : base("{+baseurl}/videolibrary?includeAccessKey={includeAccessKey}&page={page}&perPage={perPage}&search={search}", rawUrl)
        {
        }
        /// <summary>
        /// [ListVideoLibraries API Docs](https://docs.bunny.net/reference/videolibrarypublic_index)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.VideolibraryRequestBuilder.VideolibraryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.VideolibraryRequestBuilder.VideolibraryRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [AddVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_add)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/videolibrary", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [ListVideoLibraries API Docs](https://docs.bunny.net/reference/videolibrarypublic_index)
        /// </summary>
        public class VideolibraryRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeAccessKey")]
            public bool? IncludeAccessKey { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("perPage")]
            public int? PerPage { get; set; }
            /// <summary>The search term that will be used to filter the results</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
    }
}
