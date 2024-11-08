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
namespace BunnyApiClient.Videolibrary.Item.Watermark
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary\{id}\watermark
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WatermarkRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [DeleteWatermark API Docs](https://docs.bunny.net/reference/videolibrarypublic_deletewatermark)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "[DeleteWatermark API Docs](https://docs.bunny.net/reference/videolibrarypublic_deletewatermark)";
            var idOption = new Option<long?>("--id", description: "The ID of the requested Video Library") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// [AddWatermark API Docs](https://docs.bunny.net/reference/videolibrarypublic_addwatermark)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPutCommand()
        {
            var command = new Command("put");
            command.Description = "[AddWatermark API Docs](https://docs.bunny.net/reference/videolibrarypublic_addwatermark)";
            var idOption = new Option<long?>("--id", description: "The ID of the requested Video Library") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: default, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.Watermark.WatermarkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WatermarkRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/videolibrary/{id}/watermark", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.Watermark.WatermarkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WatermarkRequestBuilder(string rawUrl) : base("{+baseurl}/videolibrary/{id}/watermark", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteWatermark API Docs](https://docs.bunny.net/reference/videolibrarypublic_deletewatermark)
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
            return requestInfo;
        }
        /// <summary>
        /// [AddWatermark API Docs](https://docs.bunny.net/reference/videolibrarypublic_addwatermark)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetStreamContent(body, "image/*");
            return requestInfo;
        }
    }
}
#pragma warning restore CS0618
