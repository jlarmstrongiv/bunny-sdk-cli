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
namespace StreamApiClient.Library.Item.Videos.Item.Thumbnail
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\thumbnail
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ThumbnailRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [SetThumbnail API Docs](https://docs.bunny.net/reference/video_setthumbnail)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[SetThumbnail API Docs](https://docs.bunny.net/reference/video_setthumbnail)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var videoIdOption = new Option<string>("--video-id") {
            };
            videoIdOption.IsRequired = true;
            command.AddOption(videoIdOption);
            var thumbnailUrlOption = new Option<string>("--thumbnail-url") {
            };
            thumbnailUrlOption.IsRequired = false;
            command.AddOption(thumbnailUrlOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var videoId = invocationContext.ParseResult.GetValueForOption(videoIdOption);
                var thumbnailUrl = invocationContext.ParseResult.GetValueForOption(thumbnailUrlOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPostRequestInformation(stream, q => {
                    if (!string.IsNullOrEmpty(thumbnailUrl)) q.QueryParameters.ThumbnailUrl = thumbnailUrl;
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (videoId is not null) requestInfo.PathParameters.Add("videoId", videoId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ThumbnailRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/videos/{videoId}/thumbnail{?thumbnailUrl}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ThumbnailRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/videos/{videoId}/thumbnail{?thumbnailUrl}", rawUrl)
        {
        }
        /// <summary>
        /// [SetThumbnail API Docs](https://docs.bunny.net/reference/video_setthumbnail)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder.ThumbnailRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder.ThumbnailRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, "image/*");
            return requestInfo;
        }
        /// <summary>
        /// [SetThumbnail API Docs](https://docs.bunny.net/reference/video_setthumbnail)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ThumbnailRequestBuilderPostQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("thumbnailUrl")]
            public string? ThumbnailUrl { get; set; }
#nullable restore
#else
            [QueryParameter("thumbnailUrl")]
            public string ThumbnailUrl { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
