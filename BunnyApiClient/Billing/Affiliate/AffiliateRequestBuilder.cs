// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Billing.Affiliate.Claim;
using BunnyApiClient.Models.Billing.GetAffiliateDetails;
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
namespace BunnyApiClient.Billing.Affiliate
{
    /// <summary>
    /// Builds and executes requests for operations under \billing\affiliate
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AffiliateRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The claim property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildClaimNavCommand()
        {
            var command = new Command("claim");
            command.Description = "The claim property";
            var builder = new global::BunnyApiClient.Billing.Affiliate.Claim.ClaimRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// [GetAffiliateDetails API Docs](https://docs.bunny.net/reference/billingpublic_affiliatedetails)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetAffiliateDetails API Docs](https://docs.bunny.net/reference/billingpublic_affiliatedetails)";
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Billing.Affiliate.AffiliateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AffiliateRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/billing/affiliate", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Billing.Affiliate.AffiliateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AffiliateRequestBuilder(string rawUrl) : base("{+baseurl}/billing/affiliate", rawUrl)
        {
        }
        /// <summary>
        /// [GetAffiliateDetails API Docs](https://docs.bunny.net/reference/billingpublic_affiliatedetails)
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
#pragma warning restore CS0618
