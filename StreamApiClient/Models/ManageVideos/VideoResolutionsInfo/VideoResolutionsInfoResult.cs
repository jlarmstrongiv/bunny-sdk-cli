// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace StreamApiClient.Models.ManageVideos.VideoResolutionsInfo
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class VideoResolutionsInfoResult : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The resolutions info.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult_data? Data { get; set; }
#nullable restore
#else
        public global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult_data Data { get; set; }
#endif
        /// <summary>Response message description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The response status code</summary>
        public int? StatusCode { get; set; }
        /// <summary>Determines if the request was successful</summary>
        public bool? Success { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult"/> and sets the default values.
        /// </summary>
        public VideoResolutionsInfoResult()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult_data>(global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult_data.CreateFromDiscriminatorValue); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "statusCode", n => { StatusCode = n.GetIntValue(); } },
                { "success", n => { Success = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::StreamApiClient.Models.ManageVideos.VideoResolutionsInfo.VideoResolutionsInfoResult_data>("data", Data);
            writer.WriteStringValue("message", Message);
            writer.WriteIntValue("statusCode", StatusCode);
            writer.WriteBoolValue("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
