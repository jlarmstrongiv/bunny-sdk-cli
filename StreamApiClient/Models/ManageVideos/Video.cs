// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using StreamApiClient.Models.ManageVideos.TranscodingMessage;
using System.Collections.Generic;
using System.IO;
using System;
namespace StreamApiClient.Models.ManageVideos
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Video : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The available resolutions of the video</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailableResolutions { get; private set; }
#nullable restore
#else
        public string AvailableResolutions { get; private set; }
#endif
        /// <summary>The average watch time of the video in seconds</summary>
        public long? AverageWatchTime { get; private set; }
        /// <summary>The captions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::StreamApiClient.Models.ManageVideos.Caption>? Captions { get; set; }
#nullable restore
#else
        public List<global::StreamApiClient.Models.ManageVideos.Caption> Captions { get; set; }
#endif
        /// <summary>The automatically detected category of the video</summary>
        public global::StreamApiClient.Models.ManageVideos.Video_category? Category { get; private set; }
        /// <summary>The list of chapters available for the video</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::StreamApiClient.Models.ManageVideos.Chapter>? Chapters { get; set; }
#nullable restore
#else
        public List<global::StreamApiClient.Models.ManageVideos.Chapter> Chapters { get; set; }
#endif
        /// <summary>The ID of the collection where the video belongs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CollectionId { get; set; }
#nullable restore
#else
        public string CollectionId { get; set; }
#endif
        /// <summary>The date when the video was uploaded</summary>
        public DateTimeOffset? DateUploaded { get; private set; }
        /// <summary>The current encode progress of the video</summary>
        public int? EncodeProgress { get; private set; }
        /// <summary>The framerate of the video</summary>
        public double? Framerate { get; private set; }
        /// <summary>The unique ID of the video</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Guid { get; private set; }
#nullable restore
#else
        public string Guid { get; private set; }
#endif
        /// <summary>Determines if the video has MP4 fallback files generated</summary>
        public bool? HasMP4Fallback { get; private set; }
        /// <summary>The height of the original video file</summary>
        public int? Height { get; private set; }
        /// <summary>Determines if the video is publicly accessible</summary>
        public bool? IsPublic { get; private set; }
        /// <summary>The duration of the video in seconds</summary>
        public int? Length { get; private set; }
        /// <summary>The list of meta tags that have been added to the video</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::StreamApiClient.Models.ManageVideos.MetaTag>? MetaTags { get; set; }
#nullable restore
#else
        public List<global::StreamApiClient.Models.ManageVideos.MetaTag> MetaTags { get; set; }
#endif
        /// <summary>The list of moments available for the video</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::StreamApiClient.Models.ManageVideos.Moment>? Moments { get; set; }
#nullable restore
#else
        public List<global::StreamApiClient.Models.ManageVideos.Moment> Moments { get; set; }
#endif
        /// <summary>The rotation of the video</summary>
        public int? Rotation { get; private set; }
        /// <summary>The status of the video.</summary>
        public double? Status { get; private set; }
        /// <summary>The amount of storage used by this video</summary>
        public long? StorageSize { get; private set; }
        /// <summary>The number of thumbnails generated for this video</summary>
        public int? ThumbnailCount { get; private set; }
        /// <summary>The file name of the thumbnail inside of the storage</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailFileName { get; private set; }
#nullable restore
#else
        public string ThumbnailFileName { get; private set; }
#endif
        /// <summary>The title of the video</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The total video watch time in seconds</summary>
        public long? TotalWatchTime { get; private set; }
        /// <summary>The list of transcoding messages that describe potential issues while the video was transcoding</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::StreamApiClient.Models.ManageVideos.TranscodingMessage.TranscodingMessage>? TranscodingMessages { get; private set; }
#nullable restore
#else
        public List<global::StreamApiClient.Models.ManageVideos.TranscodingMessage.TranscodingMessage> TranscodingMessages { get; private set; }
#endif
        /// <summary>The ID of the video library that the video belongs to</summary>
        public long? VideoLibraryId { get; private set; }
        /// <summary>The number of views the video received</summary>
        public long? Views { get; private set; }
        /// <summary>The width of the original video file</summary>
        public int? Width { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Models.ManageVideos.Video"/> and sets the default values.
        /// </summary>
        public Video()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.Video"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::StreamApiClient.Models.ManageVideos.Video CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::StreamApiClient.Models.ManageVideos.Video();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "availableResolutions", n => { AvailableResolutions = n.GetStringValue(); } },
                { "averageWatchTime", n => { AverageWatchTime = n.GetLongValue(); } },
                { "captions", n => { Captions = n.GetCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.Caption>(global::StreamApiClient.Models.ManageVideos.Caption.CreateFromDiscriminatorValue)?.AsList(); } },
                { "category", n => { Category = n.GetEnumValue<global::StreamApiClient.Models.ManageVideos.Video_category>(); } },
                { "chapters", n => { Chapters = n.GetCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.Chapter>(global::StreamApiClient.Models.ManageVideos.Chapter.CreateFromDiscriminatorValue)?.AsList(); } },
                { "collectionId", n => { CollectionId = n.GetStringValue(); } },
                { "dateUploaded", n => { DateUploaded = n.GetDateTimeOffsetValue(); } },
                { "encodeProgress", n => { EncodeProgress = n.GetIntValue(); } },
                { "framerate", n => { Framerate = n.GetDoubleValue(); } },
                { "guid", n => { Guid = n.GetStringValue(); } },
                { "hasMP4Fallback", n => { HasMP4Fallback = n.GetBoolValue(); } },
                { "height", n => { Height = n.GetIntValue(); } },
                { "isPublic", n => { IsPublic = n.GetBoolValue(); } },
                { "length", n => { Length = n.GetIntValue(); } },
                { "metaTags", n => { MetaTags = n.GetCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.MetaTag>(global::StreamApiClient.Models.ManageVideos.MetaTag.CreateFromDiscriminatorValue)?.AsList(); } },
                { "moments", n => { Moments = n.GetCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.Moment>(global::StreamApiClient.Models.ManageVideos.Moment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "rotation", n => { Rotation = n.GetIntValue(); } },
                { "status", n => { Status = n.GetDoubleValue(); } },
                { "storageSize", n => { StorageSize = n.GetLongValue(); } },
                { "thumbnailCount", n => { ThumbnailCount = n.GetIntValue(); } },
                { "thumbnailFileName", n => { ThumbnailFileName = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "totalWatchTime", n => { TotalWatchTime = n.GetLongValue(); } },
                { "transcodingMessages", n => { TranscodingMessages = n.GetCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.TranscodingMessage.TranscodingMessage>(global::StreamApiClient.Models.ManageVideos.TranscodingMessage.TranscodingMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "videoLibraryId", n => { VideoLibraryId = n.GetLongValue(); } },
                { "views", n => { Views = n.GetLongValue(); } },
                { "width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.Caption>("captions", Captions);
            writer.WriteCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.Chapter>("chapters", Chapters);
            writer.WriteStringValue("collectionId", CollectionId);
            writer.WriteCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.MetaTag>("metaTags", MetaTags);
            writer.WriteCollectionOfObjectValues<global::StreamApiClient.Models.ManageVideos.Moment>("moments", Moments);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}