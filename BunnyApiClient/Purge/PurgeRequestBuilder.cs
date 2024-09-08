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
namespace BunnyApiClient.Purge
{
    /// <summary>
    /// Builds and executes requests for operations under \purge
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PurgeRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// [PurgeUrlGet API Docs](https://docs.bunny.net/reference/purgepublic_index)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[PurgeUrlGet API Docs](https://docs.bunny.net/reference/purgepublic_index)";
            var urlOption = new Option<string>("--url") {
            };
            urlOption.IsRequired = true;
            command.AddOption(urlOption);
            var headerNameOption = new Option<string>("--header-name") {
            };
            headerNameOption.IsRequired = true;
            command.AddOption(headerNameOption);
            var headerValueOption = new Option<string>("--header-value") {
            };
            headerValueOption.IsRequired = true;
            command.AddOption(headerValueOption);
            var asyncOption = new Option<bool?>("--async") {
            };
            asyncOption.IsRequired = true;
            command.AddOption(asyncOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var url = invocationContext.ParseResult.GetValueForOption(urlOption);
                var headerName = invocationContext.ParseResult.GetValueForOption(headerNameOption);
                var headerValue = invocationContext.ParseResult.GetValueForOption(headerValueOption);
                var async = invocationContext.ParseResult.GetValueForOption(asyncOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(url)) q.QueryParameters.Url = url;
                    if (!string.IsNullOrEmpty(headerName)) q.QueryParameters.HeaderName = headerName;
                    if (!string.IsNullOrEmpty(headerValue)) q.QueryParameters.HeaderValue = headerValue;
                    q.QueryParameters.Async = async;
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
        /// [PurgeUrlPost API Docs](https://docs.bunny.net/reference/purgepublic_indexpost)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[PurgeUrlPost API Docs](https://docs.bunny.net/reference/purgepublic_indexpost)";
            var urlOption = new Option<string>("--url") {
            };
            urlOption.IsRequired = true;
            command.AddOption(urlOption);
            var asyncOption = new Option<bool?>("--async") {
            };
            asyncOption.IsRequired = true;
            command.AddOption(asyncOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var url = invocationContext.ParseResult.GetValueForOption(urlOption);
                var async = invocationContext.ParseResult.GetValueForOption(asyncOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                    if (!string.IsNullOrEmpty(url)) q.QueryParameters.Url = url;
                    q.QueryParameters.Async = async;
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
        /// Instantiates a new <see cref="global::BunnyApiClient.Purge.PurgeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PurgeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/purge?async={async}&headerName={headerName}&headerValue={headerValue}&url={url}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Purge.PurgeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PurgeRequestBuilder(string rawUrl) : base("{+baseurl}/purge?async={async}&headerName={headerName}&headerValue={headerValue}&url={url}", rawUrl)
        {
        }
        /// <summary>
        /// [PurgeUrlGet API Docs](https://docs.bunny.net/reference/purgepublic_index)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Purge.PurgeRequestBuilder.PurgeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Purge.PurgeRequestBuilder.PurgeRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// [PurgeUrlPost API Docs](https://docs.bunny.net/reference/purgepublic_indexpost)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Purge.PurgeRequestBuilder.PurgeRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Purge.PurgeRequestBuilder.PurgeRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/purge?async={async}&url={url}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// [PurgeUrlGet API Docs](https://docs.bunny.net/reference/purgepublic_index)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PurgeRequestBuilderGetQueryParameters 
        {
            [QueryParameter("async")]
            public bool? Async { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("headerName")]
            public string? HeaderName { get; set; }
#nullable restore
#else
            [QueryParameter("headerName")]
            public string HeaderName { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("headerValue")]
            public string? HeaderValue { get; set; }
#nullable restore
#else
            [QueryParameter("headerValue")]
            public string HeaderValue { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("url")]
            public string? Url { get; set; }
#nullable restore
#else
            [QueryParameter("url")]
            public string Url { get; set; }
#endif
        }
        /// <summary>
        /// [PurgeUrlPost API Docs](https://docs.bunny.net/reference/purgepublic_indexpost)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PurgeRequestBuilderPostQueryParameters 
        {
            [QueryParameter("async")]
            public bool? Async { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("url")]
            public string? Url { get; set; }
#nullable restore
#else
            [QueryParameter("url")]
            public string Url { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
