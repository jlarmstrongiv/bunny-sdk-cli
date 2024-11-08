// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using StreamApiClient.Models;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos.Fetch
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\fetch
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FetchRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [FetchVideo API Docs](https://docs.bunny.net/reference/video_fetchnewvideo)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[FetchVideo API Docs](https://docs.bunny.net/reference/video_fetchnewvideo)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var collectionIdOption = new Option<string>("--collection-id") {
            };
            collectionIdOption.IsRequired = false;
            command.AddOption(collectionIdOption);
            var thumbnailTimeOption = new Option<int?>("--thumbnail-time", description: "Video time in ms to extract the main video thumbnail.") {
            };
            thumbnailTimeOption.IsRequired = false;
            command.AddOption(thumbnailTimeOption);
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
                var thumbnailTime = invocationContext.ParseResult.GetValueForOption(thumbnailTimeOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::StreamApiClient.Library.Item.Videos.Fetch.FetchPostRequestBody>(global::StreamApiClient.Library.Item.Videos.Fetch.FetchPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                    if (!string.IsNullOrEmpty(collectionId)) q.QueryParameters.CollectionId = collectionId;
                    q.QueryParameters.ThumbnailTime = thumbnailTime;
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
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public FetchRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/videos/fetch{?collectionId,thumbnailTime}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public FetchRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/videos/fetch{?collectionId,thumbnailTime}", rawUrl)
        {
        }
        /// <summary>
        /// [FetchVideo API Docs](https://docs.bunny.net/reference/video_fetchnewvideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Library.Item.Videos.Fetch.FetchPostRequestBody body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder.FetchRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Library.Item.Videos.Fetch.FetchPostRequestBody body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Fetch.FetchRequestBuilder.FetchRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [FetchVideo API Docs](https://docs.bunny.net/reference/video_fetchnewvideo)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FetchRequestBuilderPostQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("collectionId")]
            public string? CollectionId { get; set; }
#nullable restore
#else
            [QueryParameter("collectionId")]
            public string CollectionId { get; set; }
#endif
            /// <summary>Video time in ms to extract the main video thumbnail.</summary>
            [QueryParameter("thumbnailTime")]
            public int? ThumbnailTime { get; set; }
        }
    }
}
#pragma warning restore CS0618
