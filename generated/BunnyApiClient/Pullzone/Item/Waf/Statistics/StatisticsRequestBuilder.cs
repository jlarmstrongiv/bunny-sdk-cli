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
namespace BunnyApiClient.Pullzone.Item.Waf.Statistics
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\waf\statistics
    /// </summary>
    public class StatisticsRequestBuilder : BaseCliRequestBuilder
    {
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            var pullZoneIdOption = new Option<long?>("--pull-zone-id", description: "If set, the statistics will be only returned for the given Pull Zone") {
            };
            pullZoneIdOption.IsRequired = true;
            command.AddOption(pullZoneIdOption);
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var pullZoneId = invocationContext.ParseResult.GetValueForOption(pullZoneIdOption);
                var dateFrom = invocationContext.ParseResult.GetValueForOption(dateFromOption);
                var dateTo = invocationContext.ParseResult.GetValueForOption(dateToOption);
                var hourly = invocationContext.ParseResult.GetValueForOption(hourlyOption);
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
                });
                if (pullZoneId is not null) requestInfo.PathParameters.Add("pullZoneId", pullZoneId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StatisticsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/{%2Did}/waf/statistics{?dateFrom*,dateTo*,hourly*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StatisticsRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/{%2Did}/waf/statistics{?dateFrom*,dateTo*,hourly*}", rawUrl)
        {
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        #pragma warning disable CS1591
        public class StatisticsRequestBuilderGetQueryParameters 
        #pragma warning restore CS1591
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
        }
    }
}
