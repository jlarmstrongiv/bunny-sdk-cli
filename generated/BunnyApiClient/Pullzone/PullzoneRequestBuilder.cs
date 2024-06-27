// <auto-generated/>
using BunnyApiClient.Models.PullZone;
using BunnyApiClient.Pullzone.Checkavailability;
using BunnyApiClient.Pullzone.Item;
using BunnyApiClient.Pullzone.LoadFreeCertificate;
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
namespace BunnyApiClient.Pullzone
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone
    /// </summary>
    public class PullzoneRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The checkavailability property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCheckavailabilityNavCommand()
        {
            var command = new Command("checkavailability");
            command.Description = "The checkavailability property";
            var builder = new global::BunnyApiClient.Pullzone.Checkavailability.CheckavailabilityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Gets an item from the BunnyApiClient.pullzone.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::BunnyApiClient.Pullzone.Item.ItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildAddAllowedReferrerNavCommand());
            commands.Add(builder.BuildAddBlockedIpNavCommand());
            commands.Add(builder.BuildAddBlockedReferrerNavCommand());
            commands.Add(builder.BuildAddCertificateNavCommand());
            commands.Add(builder.BuildAddHostnameNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            commands.Add(builder.BuildEdgerulesNavCommand());
            executables.Add(builder.BuildGetCommand());
            commands.Add(builder.BuildOptimizerNavCommand());
            commands.Add(builder.BuildOriginshieldNavCommand());
            executables.Add(builder.BuildPostCommand());
            commands.Add(builder.BuildPurgeCacheNavCommand());
            commands.Add(builder.BuildRemoveAllowedReferrerNavCommand());
            commands.Add(builder.BuildRemoveBlockedIpNavCommand());
            commands.Add(builder.BuildRemoveBlockedReferrerNavCommand());
            commands.Add(builder.BuildRemoveCertificateNavCommand());
            commands.Add(builder.BuildRemoveHostnameNavCommand());
            commands.Add(builder.BuildResetSecurityKeyNavCommand());
            commands.Add(builder.BuildSafehopNavCommand());
            commands.Add(builder.BuildSetForceSSLNavCommand());
            commands.Add(builder.BuildWafNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// [AddPullZone API Docs](https://docs.bunny.net/reference/pullzonepublic_add)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "[AddPullZone API Docs](https://docs.bunny.net/reference/pullzonepublic_add)";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Models.PullZone.PullZoneCreate>(global::BunnyApiClient.Models.PullZone.PullZoneCreate.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// [ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "[ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)";
            var pageOption = new Option<int?>("--page") {
            };
            pageOption.IsRequired = true;
            command.AddOption(pageOption);
            var perPageOption = new Option<int?>("--per-page") {
            };
            perPageOption.IsRequired = true;
            command.AddOption(perPageOption);
            var searchOption = new Option<string>("--search", description: "The search term that will be used to filter the results") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var includeCertificateOption = new Option<bool?>("--include-certificate", description: "Determines if the result hostnames should contain the SSL certificate") {
            };
            includeCertificateOption.IsRequired = true;
            command.AddOption(includeCertificateOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var page = invocationContext.ParseResult.GetValueForOption(pageOption);
                var perPage = invocationContext.ParseResult.GetValueForOption(perPageOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var includeCertificate = invocationContext.ParseResult.GetValueForOption(includeCertificateOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Page = page;
                    q.QueryParameters.PerPage = perPage;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    q.QueryParameters.IncludeCertificate = includeCertificate;
                });
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The loadFreeCertificate property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLoadFreeCertificateNavCommand()
        {
            var command = new Command("load-free-certificate");
            command.Description = "The loadFreeCertificate property";
            var builder = new global::BunnyApiClient.Pullzone.LoadFreeCertificate.LoadFreeCertificateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.PullzoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public PullzoneRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone?includeCertificate={includeCertificate}&page={page}&perPage={perPage}{&search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.PullzoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PullzoneRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone?includeCertificate={includeCertificate}&page={page}&perPage={perPage}{&search*}", rawUrl)
        {
        }
        /// <summary>
        /// [ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.PullzoneRequestBuilder.PullzoneRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Pullzone.PullzoneRequestBuilder.PullzoneRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [AddPullZone API Docs](https://docs.bunny.net/reference/pullzonepublic_add)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.PullZone.PullZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.PullZone.PullZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/pullzone", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [ListPullZones API Docs](https://docs.bunny.net/reference/pullzonepublic_index)
        /// </summary>
        public class PullzoneRequestBuilderGetQueryParameters 
        {
            /// <summary>Determines if the result hostnames should contain the SSL certificate</summary>
            [QueryParameter("includeCertificate")]
            public bool? IncludeCertificate { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("perPage")]
            public int? PerPage { get; set; }
            /// <summary>The search term that will be used to filter the results</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
    }
}
