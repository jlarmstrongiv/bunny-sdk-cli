// <auto-generated/>
using BunnyApiClient.Models.StreamVideoLibrary;
using BunnyApiClient.Videolibrary.Item.AddAllowedReferrer;
using BunnyApiClient.Videolibrary.Item.AddBlockedReferrer;
using BunnyApiClient.Videolibrary.Item.RemoveAllowedReferrer;
using BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer;
using BunnyApiClient.Videolibrary.Item.ResetApiKey;
using BunnyApiClient.Videolibrary.Item.Watermark;
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
namespace BunnyApiClient.Videolibrary.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \videolibrary\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class VideolibraryItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The addAllowedReferrer property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAddAllowedReferrerNavCommand()
        {
            var command = new Command("add-allowed-referrer");
            command.Description = "The addAllowedReferrer property";
            var builder = new global::BunnyApiClient.Videolibrary.Item.AddAllowedReferrer.AddAllowedReferrerRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The addBlockedReferrer property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAddBlockedReferrerNavCommand()
        {
            var command = new Command("add-blocked-referrer");
            command.Description = "The addBlockedReferrer property";
            var builder = new global::BunnyApiClient.Videolibrary.Item.AddBlockedReferrer.AddBlockedReferrerRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// [DeleteVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_delete)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "[DeleteVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_delete)";
            var idOption = new Option<long?>("--id", description: "The ID of the Video Library that should be deleted") {
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
        /// [GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)";
            var idOption = new Option<long?>("--id", description: "The ID of the Video Library that will be returned") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var includeAccessKeyOption = new Option<bool?>("--include-access-key") {
            };
            includeAccessKeyOption.IsRequired = true;
            command.AddOption(includeAccessKeyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var includeAccessKey = invocationContext.ParseResult.GetValueForOption(includeAccessKeyOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.IncludeAccessKey = includeAccessKey;
                });
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// [UpdateVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_update)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[UpdateVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_update)";
            var idOption = new Option<long?>("--id") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            var bodyOption = new Option<string>("--body", description: "The template for adding optional properties.") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody>(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (id is not null) requestInfo.PathParameters.Add("id", id);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The removeAllowedReferrer property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRemoveAllowedReferrerNavCommand()
        {
            var command = new Command("remove-allowed-referrer");
            command.Description = "The removeAllowedReferrer property";
            var builder = new global::BunnyApiClient.Videolibrary.Item.RemoveAllowedReferrer.RemoveAllowedReferrerRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The removeBlockedReferrer property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRemoveBlockedReferrerNavCommand()
        {
            var command = new Command("remove-blocked-referrer");
            command.Description = "The removeBlockedReferrer property";
            var builder = new global::BunnyApiClient.Videolibrary.Item.RemoveBlockedReferrer.RemoveBlockedReferrerRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The resetApiKey property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResetApiKeyByIdNavCommand()
        {
            var command = new Command("reset-api-key-by-id");
            command.Description = "The resetApiKey property";
            var builder = new global::BunnyApiClient.Videolibrary.Item.ResetApiKey.ResetApiKeyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The watermark property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWatermarkNavCommand()
        {
            var command = new Command("watermark");
            command.Description = "The watermark property";
            var builder = new global::BunnyApiClient.Videolibrary.Item.Watermark.WatermarkRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public VideolibraryItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/videolibrary/{id}?includeAccessKey={includeAccessKey}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VideolibraryItemRequestBuilder(string rawUrl) : base("{+baseurl}/videolibrary/{id}?includeAccessKey={includeAccessKey}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_delete)
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/videolibrary/{id}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// [GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder.VideolibraryItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::BunnyApiClient.Videolibrary.Item.VideolibraryItemRequestBuilder.VideolibraryItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UpdateVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_update)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The template for adding optional properties.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::BunnyApiClient.Videolibrary.Item.VideolibraryPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/videolibrary/{id}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetVideoLibrary API Docs](https://docs.bunny.net/reference/videolibrarypublic_index2)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class VideolibraryItemRequestBuilderGetQueryParameters 
        {
            [QueryParameter("includeAccessKey")]
            public bool? IncludeAccessKey { get; set; }
        }
    }
}