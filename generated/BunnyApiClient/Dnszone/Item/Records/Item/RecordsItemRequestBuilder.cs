// <auto-generated/>
using BunnyApiClient.Models.DnsZone.UpdateDnsRecord;
using BunnyApiClient.Models;
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
namespace BunnyApiClient.Dnszone.Item.Records.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \dnszone\{-id}\records\{id}
    /// </summary>
    public class RecordsItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [DeleteDnsRecord API Docs](https://docs.bunny.net/reference/dnszonepublic_deleterecord)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "[DeleteDnsRecord API Docs](https://docs.bunny.net/reference/dnszonepublic_deleterecord)";
            var zoneIdOption = new Option<long?>("--zone-id", description: "The DNS Zone ID that contains the record.") {
            };
            zoneIdOption.IsRequired = true;
            command.AddOption(zoneIdOption);
            var idOption = new Option<long?>("--id", description: "The ID of the DNS record that will be deleted.") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            command.SetHandler(async (invocationContext) => {
                var zoneId = invocationContext.ParseResult.GetValueForOption(zoneIdOption);
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (zoneId is not null) requestInfo.PathParameters.Add("zoneId", zoneId);
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"400", StructuredBadRequestResponse.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// [UpdateDnsRecord API Docs](https://docs.bunny.net/reference/dnszonepublic_updaterecord)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[UpdateDnsRecord API Docs](https://docs.bunny.net/reference/dnszonepublic_updaterecord)";
            var zoneIdOption = new Option<long?>("--zone-id", description: "The DNS Zone ID that contains the record.") {
            };
            zoneIdOption.IsRequired = true;
            command.AddOption(zoneIdOption);
            var idOption = new Option<long?>("--id", description: "The ID of the DNS record that will be updated.") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var bodyOption = new Option<string>("--body", description: "The template for adding optional properties.") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var zoneId = invocationContext.ParseResult.GetValueForOption(zoneIdOption);
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.OptionalParameters>(global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.OptionalParameters.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (zoneId is not null) requestInfo.PathParameters.Add("zoneId", zoneId);
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"400", StructuredBadRequestResponse.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Dnszone.Item.Records.Item.RecordsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RecordsItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/dnszone/{%2Did}/records/{id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Dnszone.Item.Records.Item.RecordsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RecordsItemRequestBuilder(string rawUrl) : base("{+baseurl}/dnszone/{%2Did}/records/{id}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteDnsRecord API Docs](https://docs.bunny.net/reference/dnszonepublic_deleterecord)
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
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UpdateDnsRecord API Docs](https://docs.bunny.net/reference/dnszonepublic_updaterecord)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The template for adding optional properties.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.OptionalParameters body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.OptionalParameters body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
