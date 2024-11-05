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
namespace BunnyApiClient.Pullzone.LoadFreeCertificate
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\loadFreeCertificate
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LoadFreeCertificateRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)";
            var hostnameOption = new Option<string>("--hostname", description: "The hostname that the certificate will be loaded for") {
            };
            hostnameOption.IsRequired = true;
            command.AddOption(hostnameOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var hostname = invocationContext.ParseResult.GetValueForOption(hostnameOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(hostname)) q.QueryParameters.Hostname = hostname;
                });
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public LoadFreeCertificateRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/loadFreeCertificate?hostname={hostname}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public LoadFreeCertificateRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/loadFreeCertificate?hostname={hostname}", rawUrl)
        {
        }
        /// <summary>
        /// [LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder.LoadFreeCertificateRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder.LoadFreeCertificateRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// [LoadFreeCertificate API Docs](https://docs.bunny.net/reference/pullzonepublic_loadfreecertificate)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LoadFreeCertificateRequestBuilderGetQueryParameters 
        {
            /// <summary>The hostname that the certificate will be loaded for</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("hostname")]
            public string? Hostname { get; set; }
#nullable restore
#else
            [QueryParameter("hostname")]
            public string Hostname { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
