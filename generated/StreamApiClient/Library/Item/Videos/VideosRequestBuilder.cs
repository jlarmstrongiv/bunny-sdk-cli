// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using StreamApiClient.Library.Item.Videos.Fetch;
using StreamApiClient.Library.Item.Videos.Item;
using StreamApiClient.Models.ManageVideos;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos
    /// </summary>
    public class VideosRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the StreamApiClient.library.item.videos.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildCaptionsNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            commands.Add(builder.BuildHeatmapNavCommand());
            commands.Add(builder.BuildPlayNavCommand());
            executables.Add(builder.BuildPostCommand());
            executables.Add(builder.BuildPutCommand());
            commands.Add(builder.BuildReencodeNavCommand());
            commands.Add(builder.BuildRepackageNavCommand());
            commands.Add(builder.BuildThumbnailNavCommand());
            commands.Add(builder.BuildTranscribeNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// [CreateVideo API Docs](https://docs.bunny.net/reference/video_createvideo)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "[CreateVideo API Docs](https://docs.bunny.net/reference/video_createvideo)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::StreamApiClient.Models.ManageVideos.VideoCreate>(global::StreamApiClient.Models.ManageVideos.VideoCreate.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The fetch property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildFetchNavCommand()
        {
            var command = new Command("fetch");
            command.Description = "The fetch property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// [ListVideos API Docs](https://docs.bunny.net/reference/video_list)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "[ListVideos API Docs](https://docs.bunny.net/reference/video_list)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var pageOption = new Option<int?>("--page") {
            };
            pageOption.IsRequired = true;
            command.AddOption(pageOption);
            var itemsPerPageOption = new Option<int?>("--items-per-page") {
            };
            itemsPerPageOption.IsRequired = true;
            command.AddOption(itemsPerPageOption);
            var searchOption = new Option<string>("--search") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var collectionOption = new Option<string>("--collection") {
            };
            collectionOption.IsRequired = false;
            command.AddOption(collectionOption);
            var orderByOption = new Option<string>("--order-by") {
            };
            orderByOption.IsRequired = true;
            command.AddOption(orderByOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var page = invocationContext.ParseResult.GetValueForOption(pageOption);
                var itemsPerPage = invocationContext.ParseResult.GetValueForOption(itemsPerPageOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var collection = invocationContext.ParseResult.GetValueForOption(collectionOption);
                var orderBy = invocationContext.ParseResult.GetValueForOption(orderByOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Page = page;
                    q.QueryParameters.ItemsPerPage = itemsPerPage;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(collection)) q.QueryParameters.Collection = collection;
                    if (!string.IsNullOrEmpty(orderBy)) q.QueryParameters.OrderBy = (GetOrderByQueryParameterType)Enum.Parse(typeof(GetOrderByQueryParameterType), orderBy);
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.VideosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public VideosRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/videos?itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&collection*,search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.VideosRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VideosRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/videos?itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&collection*,search*}", rawUrl)
        {
        }
        /// <summary>
        /// [ListVideos API Docs](https://docs.bunny.net/reference/video_list)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder.VideosRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.VideosRequestBuilder.VideosRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [CreateVideo API Docs](https://docs.bunny.net/reference/video_createvideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/library/{libraryId}/videos", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [ListVideos API Docs](https://docs.bunny.net/reference/video_list)
        /// </summary>
        public class VideosRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("collection")]
            public string? Collection { get; set; }
#nullable restore
#else
            [QueryParameter("collection")]
            public string Collection { get; set; }
#endif
            [QueryParameter("itemsPerPage")]
            public int? ItemsPerPage { get; set; }
            [QueryParameter("orderBy")]
            public global::StreamApiClient.Library.Item.Videos.GetOrderByQueryParameterType? OrderBy { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
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
