// <auto-generated/>
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
namespace StreamApiClient.Library.Item.Videos.Item.Heatmap
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\heatmap
    /// </summary>
    public class HeatmapRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [GetVideoHeatmap API Docs](https://docs.bunny.net/reference/video_getvideoheatmap)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetVideoHeatmap API Docs](https://docs.bunny.net/reference/video_getvideoheatmap)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var videoIdOption = new Option<string>("--video-id") {
            };
            videoIdOption.IsRequired = true;
            command.AddOption(videoIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var videoId = invocationContext.ParseResult.GetValueForOption(videoIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
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
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.Item.Heatmap.HeatmapRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public HeatmapRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/videos/{videoId}/heatmap", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.Item.Heatmap.HeatmapRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public HeatmapRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/videos/{videoId}/heatmap", rawUrl)
        {
        }
        /// <summary>
        /// [GetVideoHeatmap API Docs](https://docs.bunny.net/reference/video_getvideoheatmap)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
