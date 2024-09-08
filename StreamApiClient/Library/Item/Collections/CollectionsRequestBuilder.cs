// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using StreamApiClient.Library.Item.Collections.Item;
using StreamApiClient.Models.ManageCollections;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Collections
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\collections
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CollectionsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the StreamApiClient.library.item.collections.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var builder = new global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            executables.Add(builder.BuildPostCommand());
            return new(executables, new(0));
        }
        /// <summary>
        /// [CreateCollection API Docs](https://docs.bunny.net/reference/collection_createcollection)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "[CreateCollection API Docs](https://docs.bunny.net/reference/collection_createcollection)";
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
                var model = parseNode.GetObjectValue<global::StreamApiClient.Models.ManageCollections.Collection>(global::StreamApiClient.Models.ManageCollections.Collection.CreateFromDiscriminatorValue);
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
        /// [GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "[GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)";
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
            var orderByOption = new Option<string>("--order-by") {
            };
            orderByOption.IsRequired = true;
            command.AddOption(orderByOption);
            var includeThumbnailsOption = new Option<bool?>("--include-thumbnails") {
            };
            includeThumbnailsOption.IsRequired = true;
            command.AddOption(includeThumbnailsOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var page = invocationContext.ParseResult.GetValueForOption(pageOption);
                var itemsPerPage = invocationContext.ParseResult.GetValueForOption(itemsPerPageOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var orderBy = invocationContext.ParseResult.GetValueForOption(orderByOption);
                var includeThumbnails = invocationContext.ParseResult.GetValueForOption(includeThumbnailsOption);
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
                    if (!string.IsNullOrEmpty(orderBy)) q.QueryParameters.OrderBy = (GetOrderByQueryParameterType)Enum.Parse(typeof(GetOrderByQueryParameterType), orderBy);
                    q.QueryParameters.IncludeThumbnails = includeThumbnails;
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
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CollectionsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/collections?includeThumbnails={includeThumbnails}&itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CollectionsRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/collections?includeThumbnails={includeThumbnails}&itemsPerPage={itemsPerPage}&orderBy={orderBy}&page={page}{&search}", rawUrl)
        {
        }
        /// <summary>
        /// [GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.CollectionsRequestBuilder.CollectionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [CreateCollection API Docs](https://docs.bunny.net/reference/collection_createcollection)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageCollections.Collection body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/library/{libraryId}/collections", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetCollectionList API Docs](https://docs.bunny.net/reference/collection_list)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CollectionsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeThumbnails")]
            public bool? IncludeThumbnails { get; set; }
            [QueryParameter("itemsPerPage")]
            public int? ItemsPerPage { get; set; }
            [QueryParameter("orderBy")]
            public global::StreamApiClient.Library.Item.Collections.GetOrderByQueryParameterType? OrderBy { get; set; }
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
#pragma warning restore CS0618
