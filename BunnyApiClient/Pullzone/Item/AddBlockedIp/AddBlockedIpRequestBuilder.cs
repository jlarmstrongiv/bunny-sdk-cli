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
namespace BunnyApiClient.Pullzone.Item.AddBlockedIp
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\addBlockedIp
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class AddBlockedIpRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [AddBlockedIp API Docs](https://docs.bunny.net/reference/pullzonepublic_addblockedip)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[AddBlockedIp API Docs](https://docs.bunny.net/reference/pullzonepublic_addblockedip)";
            var idOption = new Option<long?>("--id", description: "The ID of the requested Pull Zone") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Pullzone.Item.AddBlockedIp.AddBlockedIpPostRequestBody>(global::BunnyApiClient.Pullzone.Item.AddBlockedIp.AddBlockedIpPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (id is not null) requestInfo.PathParameters.Add("%2Did", id);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.AddBlockedIp.AddBlockedIpRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AddBlockedIpRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/{%2Did}/addBlockedIp", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.AddBlockedIp.AddBlockedIpRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AddBlockedIpRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/{%2Did}/addBlockedIp", rawUrl)
        {
        }
        /// <summary>
        /// [AddBlockedIp API Docs](https://docs.bunny.net/reference/pullzonepublic_addblockedip)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Pullzone.Item.AddBlockedIp.AddBlockedIpPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Pullzone.Item.AddBlockedIp.AddBlockedIpPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
    }
}
