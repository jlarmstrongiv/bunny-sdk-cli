// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using StreamApiClient.Library.Item.Videos.Item.Captions;
using StreamApiClient.Library.Item.Videos.Item.Heatmap;
using StreamApiClient.Library.Item.Videos.Item.Play;
using StreamApiClient.Library.Item.Videos.Item.Reencode;
using StreamApiClient.Library.Item.Videos.Item.Repackage;
using StreamApiClient.Library.Item.Videos.Item.Thumbnail;
using StreamApiClient.Library.Item.Videos.Item.Transcribe;
using StreamApiClient.Models.ManageVideos;
using StreamApiClient.Models;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace StreamApiClient.Library.Item.Videos.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}
    /// </summary>
    public class WithVideoItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The captions property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCaptionsNavCommand()
        {
            var command = new Command("captions");
            command.Description = "The captions property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder(PathParameters);
            var nonExecCommands = new List<Command>();
            var cmds = builder.BuildCommand();
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// [DeleteVideo API Docs](https://docs.bunny.net/reference/video_deletevideo)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "[DeleteVideo API Docs](https://docs.bunny.net/reference/video_deletevideo)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var videoIdOption = new Option<string>("--video-id") {
            };
            videoIdOption.IsRequired = true;
            command.AddOption(videoIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var videoId = invocationContext.ParseResult.GetValueForOption(videoIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (videoId is not null) requestInfo.PathParameters.Add("videoId", videoId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// [GetVideo API Docs](https://docs.bunny.net/reference/video_getvideo)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "[GetVideo API Docs](https://docs.bunny.net/reference/video_getvideo)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var videoIdOption = new Option<string>("--video-id") {
            };
            videoIdOption.IsRequired = true;
            command.AddOption(videoIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var videoId = invocationContext.ParseResult.GetValueForOption(videoIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (videoId is not null) requestInfo.PathParameters.Add("videoId", videoId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The heatmap property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildHeatmapNavCommand()
        {
            var command = new Command("heatmap");
            command.Description = "The heatmap property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Heatmap.HeatmapRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The play property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPlayNavCommand()
        {
            var command = new Command("play");
            command.Description = "The play property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Play.PlayRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// [UpdateVideo API Docs](https://docs.bunny.net/reference/video_updatevideo)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "[UpdateVideo API Docs](https://docs.bunny.net/reference/video_updatevideo)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var videoIdOption = new Option<string>("--video-id") {
            };
            videoIdOption.IsRequired = true;
            command.AddOption(videoIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var videoId = invocationContext.ParseResult.GetValueForOption(videoIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<global::StreamApiClient.Models.ManageVideos.VideoCreate>(global::StreamApiClient.Models.ManageVideos.VideoCreate.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (videoId is not null) requestInfo.PathParameters.Add("videoId", videoId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// [UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPutCommand()
        {
            var command = new Command("put");
            command.Description = "[UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)";
            var libraryIdOption = new Option<long?>("--library-id") {
            };
            libraryIdOption.IsRequired = true;
            command.AddOption(libraryIdOption);
            var videoIdOption = new Option<string>("--video-id") {
            };
            videoIdOption.IsRequired = true;
            command.AddOption(videoIdOption);
            var enabledResolutionsOption = new Option<string>("--enabled-resolutions") {
            };
            enabledResolutionsOption.IsRequired = false;
            command.AddOption(enabledResolutionsOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var libraryId = invocationContext.ParseResult.GetValueForOption(libraryIdOption);
                var videoId = invocationContext.ParseResult.GetValueForOption(videoIdOption);
                var enabledResolutions = invocationContext.ParseResult.GetValueForOption(enabledResolutionsOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) {
                    Console.Error.WriteLine("No available file to send.");
                    return;
                }
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                    if (!string.IsNullOrEmpty(enabledResolutions)) q.QueryParameters.EnabledResolutions = enabledResolutions;
                });
                if (libraryId is not null) requestInfo.PathParameters.Add("libraryId", libraryId);
                if (videoId is not null) requestInfo.PathParameters.Add("videoId", videoId);
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: default, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// The reencode property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildReencodeNavCommand()
        {
            var command = new Command("reencode");
            command.Description = "The reencode property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Reencode.ReencodeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The repackage property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRepackageNavCommand()
        {
            var command = new Command("repackage");
            command.Description = "The repackage property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Repackage.RepackageRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The thumbnail property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildThumbnailNavCommand()
        {
            var command = new Command("thumbnail");
            command.Description = "The thumbnail property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Thumbnail.ThumbnailRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The transcribe property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTranscribeNavCommand()
        {
            var command = new Command("transcribe");
            command.Description = "The transcribe property";
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Transcribe.TranscribeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WithVideoItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/videos/{videoId}{?enabledResolutions*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithVideoItemRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/videos/{videoId}{?enabledResolutions*}", rawUrl)
        {
        }
        /// <summary>
        /// [DeleteVideo API Docs](https://docs.bunny.net/reference/video_deletevideo)
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
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [GetVideo API Docs](https://docs.bunny.net/reference/video_getvideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UpdateVideo API Docs](https://docs.bunny.net/reference/video_updatevideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::StreamApiClient.Models.ManageVideos.VideoCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// [UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder.WithVideoItemRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<global::StreamApiClient.Library.Item.Videos.Item.WithVideoItemRequestBuilder.WithVideoItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// [UploadVideo API Docs](https://docs.bunny.net/reference/video_uploadvideo)
        /// </summary>
        public class WithVideoItemRequestBuilderPutQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("enabledResolutions")]
            public string? EnabledResolutions { get; set; }
#nullable restore
#else
            [QueryParameter("enabledResolutions")]
            public string EnabledResolutions { get; set; }
#endif
        }
    }
}
