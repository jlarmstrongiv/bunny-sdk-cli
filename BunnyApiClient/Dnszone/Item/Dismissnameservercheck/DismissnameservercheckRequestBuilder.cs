// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.DnsZone;
using BunnyApiClient.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace BunnyApiClient.Dnszone.Item.Dismissnameservercheck
{
    /// <summary>
    /// Builds and executes requests for operations under \dnszone\{-id}\dismissnameservercheck
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DismissnameservercheckRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [DismissDnsConfigurationNotice API Docs](https://docs.bunny.net/reference/dnszonepublic_dismissnameservercheck)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[DismissDnsConfigurationNotice API Docs](https://docs.bunny.net/reference/dnszonepublic_dismissnameservercheck)";
            var idOption = new Option<long?>("--id") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (id is not null) requestInfo.PathParameters.Add("%2Did", id);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"400", StructuredBadRequestResponse.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.Dismissnameservercheck.DismissnameservercheckRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DismissnameservercheckRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/dnszone/{%2Did}/dismissnameservercheck", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.Dismissnameservercheck.DismissnameservercheckRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DismissnameservercheckRequestBuilder(string rawUrl) : base("{+baseurl}/dnszone/{%2Did}/dismissnameservercheck", rawUrl)
        {
        }
        /// <summary>
        /// [DismissDnsConfigurationNotice API Docs](https://docs.bunny.net/reference/dnszonepublic_dismissnameservercheck)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
