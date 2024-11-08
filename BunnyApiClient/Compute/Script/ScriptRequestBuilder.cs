// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Compute.Script.Item;
using BunnyApiClient.Models.Compute;
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
namespace BunnyApiClient.Compute.Script
{
    /// <summary>
    /// Builds and executes requests for operations under \compute\script
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScriptRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the BunnyApiClient.compute.script.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::BunnyApiClient.Compute.Script.Item.ScriptItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildCodeNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            executables.Add(builder.BuildPostCommand());
            commands.Add(builder.BuildPublishNavCommand());
            commands.Add(builder.BuildReleasesNavCommand());
            commands.Add(builder.BuildVariablesNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// [AddComputeScript API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_addscript)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "[AddComputeScript API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_addscript)";
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
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Models.Compute.ScriptCreate>(global::BunnyApiClient.Models.Compute.ScriptCreate.CreateFromDiscriminatorValue);
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
        /// [ListComputeScripts API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_index)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "[ListComputeScripts API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_index)";
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
            searchOption.IsRequired = true;
            command.AddOption(searchOption);
            var includeLinkedPullZonesOption = new Option<bool?>("--include-linked-pull-zones") {
            };
            includeLinkedPullZonesOption.IsRequired = false;
            command.AddOption(includeLinkedPullZonesOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var page = invocationContext.ParseResult.GetValueForOption(pageOption);
                var perPage = invocationContext.ParseResult.GetValueForOption(perPageOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var includeLinkedPullZones = invocationContext.ParseResult.GetValueForOption(includeLinkedPullZonesOption);
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
                    q.QueryParameters.IncludeLinkedPullZones = includeLinkedPullZones;
                });
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.ScriptRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ScriptRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/compute/script?page={page}&perPage={perPage}&search={search}{&includeLinkedPullZones}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.ScriptRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ScriptRequestBuilder(string rawUrl) : base("{+baseurl}/compute/script?page={page}&perPage={perPage}&search={search}{&includeLinkedPullZones}", rawUrl)
        {
        }
        /// <summary>
        /// [ListComputeScripts API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_index)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Compute.Script.ScriptRequestBuilder.ScriptRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Compute.Script.ScriptRequestBuilder.ScriptRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [AddComputeScript API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_addscript)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.Compute.ScriptCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.Compute.ScriptCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/compute/script", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [ListComputeScripts API Docs](https://docs.bunny.net/reference/computeedgescriptpublic_index)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScriptRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeLinkedPullZones")]
            public bool? IncludeLinkedPullZones { get; set; }
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
#pragma warning restore CS0618
