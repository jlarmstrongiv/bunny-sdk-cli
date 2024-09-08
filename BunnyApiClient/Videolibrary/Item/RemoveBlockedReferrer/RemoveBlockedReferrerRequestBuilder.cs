// <auto-generated/>
#pragma warning disable CS0618
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
namespace BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary\{id}\removeBlockedReferrer
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RemoveBlockedReferrerRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [RemoveBlockedReferer API Docs](https://docs.bunny.net/reference/videolibrarypublic_removeblockedreferrer)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[RemoveBlockedReferer API Docs](https://docs.bunny.net/reference/videolibrarypublic_removeblockedreferrer)";
            var idOption = new Option<long?>("--id", description: "The ID of the requested Video Library") {
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
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerPostRequestBody>(global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RemoveBlockedReferrerRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/videolibrary/{id}/removeBlockedReferrer", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RemoveBlockedReferrerRequestBuilder(string rawUrl) : base("{+baseurl}/videolibrary/{id}/removeBlockedReferrer", rawUrl)
        {
        }
        /// <summary>
        /// [RemoveBlockedReferer API Docs](https://docs.bunny.net/reference/videolibrarypublic_removeblockedreferrer)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
