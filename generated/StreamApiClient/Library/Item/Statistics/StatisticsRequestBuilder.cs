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
namespace StreamApiClient.Library.Item.Statistics
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\statistics
    /// </summary>
    public class StatisticsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var dateFromOption = new Option<DateTimeOffset?>("--date-from", description: "The start date of the statistics. If no value is passed, the last 30 days will be returned.") {
            };
            dateFromOption.IsRequired = false;
            command.AddOption(dateFromOption);
            var dateToOption = new Option<DateTimeOffset?>("--date-to", description: "The end date of the statistics. If no value is passed, the last 30 days will be returned.") {
            };
            dateToOption.IsRequired = false;
            command.AddOption(dateToOption);
            var hourlyOption = new Option<bool?>("--hourly", description: "If true, the statistics data will be returned in hourly grouping.") {
            };
            hourlyOption.IsRequired = false;
            command.AddOption(hourlyOption);
            var videoGuidOption = new Option<string>("--video-guid", description: "The GUID of the video for which the statistics will be returned") {
            };
            videoGuidOption.IsRequired = false;
            command.AddOption(videoGuidOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var dateFrom = invocationContext.ParseResult.GetValueForOption(dateFromOption);
                var dateTo = invocationContext.ParseResult.GetValueForOption(dateToOption);
                var hourly = invocationContext.ParseResult.GetValueForOption(hourlyOption);
                var videoGuid = invocationContext.ParseResult.GetValueForOption(videoGuidOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.DateFrom = dateFrom;
                    q.QueryParameters.DateTo = dateTo;
                    q.QueryParameters.Hourly = hourly;
                    if (!string.IsNullOrEmpty(videoGuid)) q.QueryParameters.VideoGuid = videoGuid;
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
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StatisticsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/statistics{?dateFrom*,dateTo*,hourly*,videoGuid*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StatisticsRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/statistics{?dateFrom*,dateTo*,hourly*,videoGuid*}", rawUrl)
        {
        }
        /// <summary>
        /// [GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::StreamApiClient.Library.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetVideoStatistics API Docs](https://docs.bunny.net/reference/video_getvideostatistics)
        /// </summary>
        public class StatisticsRequestBuilderGetQueryParameters 
        {
            /// <summary>The start date of the statistics. If no value is passed, the last 30 days will be returned.</summary>
            [QueryParameter("dateFrom")]
            public DateTimeOffset? DateFrom { get; set; }
            /// <summary>The end date of the statistics. If no value is passed, the last 30 days will be returned.</summary>
            [QueryParameter("dateTo")]
            public DateTimeOffset? DateTo { get; set; }
            /// <summary>If true, the statistics data will be returned in hourly grouping.</summary>
            [QueryParameter("hourly")]
            public bool? Hourly { get; set; }
            /// <summary>The GUID of the video for which the statistics will be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("videoGuid")]
            public string? VideoGuid { get; set; }
#nullable restore
#else
            [QueryParameter("videoGuid")]
            public string VideoGuid { get; set; }
#endif
        }
    }
}