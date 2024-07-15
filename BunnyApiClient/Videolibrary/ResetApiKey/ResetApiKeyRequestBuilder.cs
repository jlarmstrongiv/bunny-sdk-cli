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
namespace BunnyApiClient.Videolibrary.ResetApiKey
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary\resetApiKey
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ResetApiKeyRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)";
            var idOption = new Option<long?>("--id", description: "The ID of the Video Library that should have the password reset") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                    q.QueryParameters.Id = id;
                });
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ResetApiKeyRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/videolibrary/resetApiKey?id={id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ResetApiKeyRequestBuilder(string rawUrl) : base("{+baseurl}/videolibrary/resetApiKey?id={id}", rawUrl)
        {
        }
        /// <summary>
        /// [ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder.ResetApiKeyRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.ResetApiKey.ResetApiKeyRequestBuilder.ResetApiKeyRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// [ResetPasswordQuery API Docs](https://docs.bunny.net/reference/videolibrarypublic_resetpassword)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ResetApiKeyRequestBuilderPostQueryParameters 
        {
            /// <summary>The ID of the Video Library that should have the password reset</summary>
            [QueryParameter("id")]
            public long? Id { get; set; }
        }
    }
}