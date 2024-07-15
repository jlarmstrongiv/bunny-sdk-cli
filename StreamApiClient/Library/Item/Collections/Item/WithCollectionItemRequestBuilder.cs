// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using StreamApiClient.Models.ManageCollections;
using StreamApiClient.Models;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Collections.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\collections\{collectionId}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class WithCollectionItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [DeleteCollection API Docs](https://docs.bunny.net/reference/collection_deletecollection)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "[DeleteCollection API Docs](https://docs.bunny.net/reference/collection_deletecollection)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var collectionIdOption = new Option<string>("--collection-id") {
            };
            collectionIdOption.IsRequired = true;
            command.AddOption(collectionIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var collectionId = invocationContext.ParseResult.GetValueForOption(collectionIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (collectionId is not null) requestInfo.PathParameters.Add("collectionId", collectionId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// [GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var collectionIdOption = new Option<string>("--collection-id") {
            };
            collectionIdOption.IsRequired = true;
            command.AddOption(collectionIdOption);
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
                var collectionId = invocationContext.ParseResult.GetValueForOption(collectionIdOption);
                var includeThumbnails = invocationContext.ParseResult.GetValueForOption(includeThumbnailsOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.IncludeThumbnails = includeThumbnails;
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (collectionId is not null) requestInfo.PathParameters.Add("collectionId", collectionId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// [UpdateCollection API Docs](https://docs.bunny.net/reference/collection_updatecollection)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[UpdateCollection API Docs](https://docs.bunny.net/reference/collection_updatecollection)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var collectionIdOption = new Option<string>("--collection-id") {
            };
            collectionIdOption.IsRequired = true;
            command.AddOption(collectionIdOption);
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
                var collectionId = invocationContext.ParseResult.GetValueForOption(collectionIdOption);
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
                if (collectionId is not null) requestInfo.PathParameters.Add("collectionId", collectionId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WithCollectionItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/collections/{collectionId}?includeThumbnails={includeThumbnails}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithCollectionItemRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/collections/{collectionId}?includeThumbnails={includeThumbnails}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteCollection API Docs](https://docs.bunny.net/reference/collection_deletecollection)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/library/{libraryId}/collections/{collectionId}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder.WithCollectionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Collections.Item.WithCollectionItemRequestBuilder.WithCollectionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UpdateCollection API Docs](https://docs.bunny.net/reference/collection_updatecollection)
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
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/library/{libraryId}/collections/{collectionId}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetCollection API Docs](https://docs.bunny.net/reference/collection_getcollection)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class WithCollectionItemRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeThumbnails")]
            public bool? IncludeThumbnails { get; set; }
        }
    }
}