// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace StreamApiClient.Models.ManageVideos.GetVideoPlayData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class VideoPlayData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allowEarlyPlay property</summary>
        public bool? AllowEarlyPlay { get; set; }
        /// <summary>The captionsBackground property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptionsBackground { get; set; }
#nullable restore
#else
        public string CaptionsBackground { get; set; }
#endif
        /// <summary>The captionsFontColor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptionsFontColor { get; set; }
#nullable restore
#else
        public string CaptionsFontColor { get; set; }
#endif
        /// <summary>The captionsFontSize property</summary>
        public int? CaptionsFontSize { get; set; }
        /// <summary>The captionsPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptionsPath { get; set; }
#nullable restore
#else
        public string CaptionsPath { get; set; }
#endif
        /// <summary>The controls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Controls { get; set; }
#nullable restore
#else
        public string Controls { get; set; }
#endif
        /// <summary>The drmVersion property</summary>
        public int? DrmVersion { get; set; }
        /// <summary>The enableDRM property</summary>
        public bool? EnableDRM { get; set; }
        /// <summary>The enableMP4Fallback property</summary>
        public bool? EnableMP4Fallback { get; set; }
        /// <summary>The fallbackUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FallbackUrl { get; set; }
#nullable restore
#else
        public string FallbackUrl { get; set; }
#endif
        /// <summary>The fontFamily property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontFamily { get; set; }
#nullable restore
#else
        public string FontFamily { get; set; }
#endif
        /// <summary>The originalUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalUrl { get; set; }
#nullable restore
#else
        public string OriginalUrl { get; set; }
#endif
        /// <summary>The playbackSpeeds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlaybackSpeeds { get; set; }
#nullable restore
#else
        public string PlaybackSpeeds { get; set; }
#endif
        /// <summary>The playerKeyColor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlayerKeyColor { get; set; }
#nullable restore
#else
        public string PlayerKeyColor { get; set; }
#endif
        /// <summary>The previewUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviewUrl { get; set; }
#nullable restore
#else
        public string PreviewUrl { get; set; }
#endif
        /// <summary>The seekPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeekPath { get; set; }
#nullable restore
#else
        public string SeekPath { get; set; }
#endif
        /// <summary>The showHeatmap property</summary>
        public bool? ShowHeatmap { get; set; }
        /// <summary>The thumbnailUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailUrl { get; set; }
#nullable restore
#else
        public string ThumbnailUrl { get; set; }
#endif
        /// <summary>The tokenAuthEnabled property</summary>
        public bool? TokenAuthEnabled { get; set; }
        /// <summary>The uiLanguage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UiLanguage { get; set; }
#nullable restore
#else
        public string UiLanguage { get; set; }
#endif
        /// <summary>The vastTagUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VastTagUrl { get; set; }
#nullable restore
#else
        public string VastTagUrl { get; set; }
#endif
        /// <summary>The video property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::StreamApiClient.Models.ManageVideos.Video? Video { get; set; }
#nullable restore
#else
        public global::StreamApiClient.Models.ManageVideos.Video Video { get; set; }
#endif
        /// <summary>The videoPlaylistUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoPlaylistUrl { get; set; }
#nullable restore
#else
        public string VideoPlaylistUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Models.ManageVideos.GetVideoPlayData.VideoPlayData"/> and sets the default values.
        /// </summary>
        public VideoPlayData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.GetVideoPlayData.VideoPlayData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::StreamApiClient.Models.ManageVideos.GetVideoPlayData.VideoPlayData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::StreamApiClient.Models.ManageVideos.GetVideoPlayData.VideoPlayData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowEarlyPlay", n => { AllowEarlyPlay = n.GetBoolValue(); } },
                { "captionsBackground", n => { CaptionsBackground = n.GetStringValue(); } },
                { "captionsFontColor", n => { CaptionsFontColor = n.GetStringValue(); } },
                { "captionsFontSize", n => { CaptionsFontSize = n.GetIntValue(); } },
                { "captionsPath", n => { CaptionsPath = n.GetStringValue(); } },
                { "controls", n => { Controls = n.GetStringValue(); } },
                { "drmVersion", n => { DrmVersion = n.GetIntValue(); } },
                { "enableDRM", n => { EnableDRM = n.GetBoolValue(); } },
                { "enableMP4Fallback", n => { EnableMP4Fallback = n.GetBoolValue(); } },
                { "fallbackUrl", n => { FallbackUrl = n.GetStringValue(); } },
                { "fontFamily", n => { FontFamily = n.GetStringValue(); } },
                { "originalUrl", n => { OriginalUrl = n.GetStringValue(); } },
                { "playbackSpeeds", n => { PlaybackSpeeds = n.GetStringValue(); } },
                { "playerKeyColor", n => { PlayerKeyColor = n.GetStringValue(); } },
                { "previewUrl", n => { PreviewUrl = n.GetStringValue(); } },
                { "seekPath", n => { SeekPath = n.GetStringValue(); } },
                { "showHeatmap", n => { ShowHeatmap = n.GetBoolValue(); } },
                { "thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                { "tokenAuthEnabled", n => { TokenAuthEnabled = n.GetBoolValue(); } },
                { "uiLanguage", n => { UiLanguage = n.GetStringValue(); } },
                { "vastTagUrl", n => { VastTagUrl = n.GetStringValue(); } },
                { "video", n => { Video = n.GetObjectValue<global::StreamApiClient.Models.ManageVideos.Video>(global::StreamApiClient.Models.ManageVideos.Video.CreateFromDiscriminatorValue); } },
                { "videoPlaylistUrl", n => { VideoPlaylistUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowEarlyPlay", AllowEarlyPlay);
            writer.WriteStringValue("captionsBackground", CaptionsBackground);
            writer.WriteStringValue("captionsFontColor", CaptionsFontColor);
            writer.WriteIntValue("captionsFontSize", CaptionsFontSize);
            writer.WriteStringValue("captionsPath", CaptionsPath);
            writer.WriteStringValue("controls", Controls);
            writer.WriteIntValue("drmVersion", DrmVersion);
            writer.WriteBoolValue("enableDRM", EnableDRM);
            writer.WriteBoolValue("enableMP4Fallback", EnableMP4Fallback);
            writer.WriteStringValue("fallbackUrl", FallbackUrl);
            writer.WriteStringValue("fontFamily", FontFamily);
            writer.WriteStringValue("originalUrl", OriginalUrl);
            writer.WriteStringValue("playbackSpeeds", PlaybackSpeeds);
            writer.WriteStringValue("playerKeyColor", PlayerKeyColor);
            writer.WriteStringValue("previewUrl", PreviewUrl);
            writer.WriteStringValue("seekPath", SeekPath);
            writer.WriteBoolValue("showHeatmap", ShowHeatmap);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteBoolValue("tokenAuthEnabled", TokenAuthEnabled);
            writer.WriteStringValue("uiLanguage", UiLanguage);
            writer.WriteStringValue("vastTagUrl", VastTagUrl);
            writer.WriteObjectValue<global::StreamApiClient.Models.ManageVideos.Video>("video", Video);
            writer.WriteStringValue("videoPlaylistUrl", VideoPlaylistUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
