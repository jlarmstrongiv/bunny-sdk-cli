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
namespace BunnyApiClient.Storagezone.Item.Statistics
{
    /// <summary>
    /// Builds and executes requests for operations under \storagezone\{id}\statistics
    /// </summary>
    public class StatisticsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [GetStorageZoneStatistics API Docs](https://docs.bunny.net/reference/storagezonepublic_storagezonestatistics)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetStorageZoneStatistics API Docs](https://docs.bunny.net/reference/storagezonepublic_storagezonestatistics)";
            var idOption = new Option<long?>("--id") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var dateFromOption = new Option<DateTimeOffset?>("--date-from") {
            };
            dateFromOption.IsRequired = false;
            command.AddOption(dateFromOption);
            var dateToOption = new Option<DateTimeOffset?>("--date-to") {
            };
            dateToOption.IsRequired = false;
            command.AddOption(dateToOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var dateFrom = invocationContext.ParseResult.GetValueForOption(dateFromOption);
                var dateTo = invocationContext.ParseResult.GetValueForOption(dateToOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.DateFrom = dateFrom;
                    q.QueryParameters.DateTo = dateTo;
                });
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Storagezone.Item.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StatisticsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/storagezone/{id}/statistics{?dateFrom*,dateTo*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Storagezone.Item.Statistics.StatisticsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StatisticsRequestBuilder(string rawUrl) : base("{+baseurl}/storagezone/{id}/statistics{?dateFrom*,dateTo*}", rawUrl)
        {
        }
        /// <summary>
        /// [GetStorageZoneStatistics API Docs](https://docs.bunny.net/reference/storagezonepublic_storagezonestatistics)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Storagezone.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Storagezone.Item.Statistics.StatisticsRequestBuilder.StatisticsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetStorageZoneStatistics API Docs](https://docs.bunny.net/reference/storagezonepublic_storagezonestatistics)
        /// </summary>
        public class StatisticsRequestBuilderGetQueryParameters 
        {
            [QueryParameter("dateFrom")]
            public DateTimeOffset? DateFrom { get; set; }
            [QueryParameter("dateTo")]
            public DateTimeOffset? DateTo { get; set; }
        }
    }
}
