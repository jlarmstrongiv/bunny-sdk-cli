// <auto-generated/>
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
namespace BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\edgerules\{edgeRuleId}\setEdgeRuleEnabled
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class SetEdgeRuleEnabledRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [SetEdgeRuleEnabled API Docs](https://docs.bunny.net/reference/pullzonepublic_setedgeruleenabled)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[SetEdgeRuleEnabled API Docs](https://docs.bunny.net/reference/pullzonepublic_setedgeruleenabled)";
            var pullZoneIdOption = new Option<long?>("--pull-zone-id", description: "The ID of the Pull Zone that contains the Edge Rule") {
            };
            pullZoneIdOption.IsRequired = true;
            command.AddOption(pullZoneIdOption);
            var edgeRuleIdOption = new Option<string>("--edge-rule-id", description: "The ID of the Edge Rule that should be updated") {
            };
            edgeRuleIdOption.IsRequired = true;
            command.AddOption(edgeRuleIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var pullZoneId = invocationContext.ParseResult.GetValueForOption(pullZoneIdOption);
                var edgeRuleId = invocationContext.ParseResult.GetValueForOption(edgeRuleIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody>(global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (pullZoneId is not null) requestInfo.PathParameters.Add("pullZoneId", pullZoneId);
                if (edgeRuleId is not null) requestInfo.PathParameters.Add("edgeRuleId", edgeRuleId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SetEdgeRuleEnabledRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/{%2Did}/edgerules/{edgeRuleId}/setEdgeRuleEnabled", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SetEdgeRuleEnabledRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/{%2Did}/edgerules/{edgeRuleId}/setEdgeRuleEnabled", rawUrl)
        {
        }
        /// <summary>
        /// [SetEdgeRuleEnabled API Docs](https://docs.bunny.net/reference/pullzonepublic_setedgeruleenabled)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
    }
}
