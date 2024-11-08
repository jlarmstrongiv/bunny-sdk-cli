// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.StorageZone;
using BunnyApiClient.Storagezone.Checkavailability;
using BunnyApiClient.Storagezone.Item;
using BunnyApiClient.Storagezone.ResetReadOnlyPassword;
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
namespace BunnyApiClient.Storagezone
{
    /// <summary>
    /// Builds and executes requests for operations under \storagezone
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StoragezoneRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The checkavailability property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCheckavailabilityNavCommand()
        {
            var command = new Command("checkavailability");
            command.Description = "The checkavailability property";
            var builder = new global::BunnyApiClient.Storagezone.Checkavailability.CheckavailabilityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Gets an item from the BunnyApiClient.storagezone.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::BunnyApiClient.Storagezone.Item.StoragezoneItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildConnectionsNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            executables.Add(builder.BuildPostCommand());
            commands.Add(builder.BuildResetPasswordNavCommand());
            commands.Add(builder.BuildStatisticsNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// [AddStorageZone API Docs](https://docs.bunny.net/reference/storagezonepublic_add)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "[AddStorageZone API Docs](https://docs.bunny.net/reference/storagezonepublic_add)";
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
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Models.StorageZone.StorageZoneCreate>(global::BunnyApiClient.Models.StorageZone.StorageZoneCreate.CreateFromDiscriminatorValue);
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
        /// [ListStorageZones API Docs](https://docs.bunny.net/reference/storagezonepublic_index)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "[ListStorageZones API Docs](https://docs.bunny.net/reference/storagezonepublic_index)";
            var pageOption = new Option<int?>("--page") {
            };
            pageOption.IsRequired = true;
            command.AddOption(pageOption);
            var perPageOption = new Option<int?>("--per-page") {
            };
            perPageOption.IsRequired = true;
            command.AddOption(perPageOption);
            var includeDeletedOption = new Option<bool?>("--include-deleted") {
            };
            includeDeletedOption.IsRequired = true;
            command.AddOption(includeDeletedOption);
            var searchOption = new Option<string>("--search") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var page = invocationContext.ParseResult.GetValueForOption(pageOption);
                var perPage = invocationContext.ParseResult.GetValueForOption(perPageOption);
                var includeDeleted = invocationContext.ParseResult.GetValueForOption(includeDeletedOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Page = page;
                    q.QueryParameters.PerPage = perPage;
                    q.QueryParameters.IncludeDeleted = includeDeleted;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                });
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The resetReadOnlyPassword property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResetReadOnlyPasswordNavCommand()
        {
            var command = new Command("reset-read-only-password");
            command.Description = "The resetReadOnlyPassword property";
            var builder = new global::BunnyApiClient.Storagezone.ResetReadOnlyPassword.ResetReadOnlyPasswordRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Storagezone.StoragezoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StoragezoneRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/storagezone?includeDeleted={includeDeleted}&page={page}&perPage={perPage}{&search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Storagezone.StoragezoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StoragezoneRequestBuilder(string rawUrl) : base("{+baseurl}/storagezone?includeDeleted={includeDeleted}&page={page}&perPage={perPage}{&search}", rawUrl)
        {
        }
        /// <summary>
        /// [ListStorageZones API Docs](https://docs.bunny.net/reference/storagezonepublic_index)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Storagezone.StoragezoneRequestBuilder.StoragezoneRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Storagezone.StoragezoneRequestBuilder.StoragezoneRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [AddStorageZone API Docs](https://docs.bunny.net/reference/storagezonepublic_add)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.StorageZone.StorageZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Models.StorageZone.StorageZoneCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/storagezone", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [ListStorageZones API Docs](https://docs.bunny.net/reference/storagezonepublic_index)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StoragezoneRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeDeleted")]
            public bool? IncludeDeleted { get; set; }
            [QueryParameter("page")]
            public int? Page { get; set; }
            [QueryParameter("perPage")]
            public int? PerPage { get; set; }
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
