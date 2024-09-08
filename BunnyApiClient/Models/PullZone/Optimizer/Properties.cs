// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.PullZone.Optimizer
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Properties : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The aspect_ratio property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AspectRatio { get; set; }
#nullable restore
#else
        public string AspectRatio { get; set; }
#endif
        /// <summary>The auto_optimize property</summary>
        public global::BunnyApiClient.Models.PullZone.Optimizer.Properties_auto_optimize? AutoOptimize { get; set; }
        /// <summary>The blur property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blur { get; set; }
#nullable restore
#else
        public string Blur { get; set; }
#endif
        /// <summary>The brightness property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Brightness { get; set; }
#nullable restore
#else
        public string Brightness { get; set; }
#endif
        /// <summary>The contrast property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Contrast { get; set; }
#nullable restore
#else
        public string Contrast { get; set; }
#endif
        /// <summary>The crop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Crop { get; set; }
#nullable restore
#else
        public string Crop { get; set; }
#endif
        /// <summary>The crop_gravity property</summary>
        public global::BunnyApiClient.Models.PullZone.Optimizer.Properties_crop_gravity? CropGravity { get; set; }
        /// <summary>The flip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Flip { get; set; }
#nullable restore
#else
        public string Flip { get; set; }
#endif
        /// <summary>The flop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Flop { get; set; }
#nullable restore
#else
        public string Flop { get; set; }
#endif
        /// <summary>The gamma property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gamma { get; set; }
#nullable restore
#else
        public string Gamma { get; set; }
#endif
        /// <summary>The height property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Height { get; set; }
#nullable restore
#else
        public string Height { get; set; }
#endif
        /// <summary>The hue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hue { get; set; }
#nullable restore
#else
        public string Hue { get; set; }
#endif
        /// <summary>The optimizer property</summary>
        public global::BunnyApiClient.Models.PullZone.Optimizer.Properties_optimizer? Optimizer { get; set; }
        /// <summary>The quality property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Quality { get; set; }
#nullable restore
#else
        public string Quality { get; set; }
#endif
        /// <summary>The saturation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Saturation { get; set; }
#nullable restore
#else
        public string Saturation { get; set; }
#endif
        /// <summary>The sharpen property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sharpen { get; set; }
#nullable restore
#else
        public string Sharpen { get; set; }
#endif
        /// <summary>The width property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Width { get; set; }
#nullable restore
#else
        public string Width { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.PullZone.Optimizer.Properties"/> and sets the default values.
        /// </summary>
        public Properties()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.PullZone.Optimizer.Properties"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.PullZone.Optimizer.Properties CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.PullZone.Optimizer.Properties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "aspect_ratio", n => { AspectRatio = n.GetStringValue(); } },
                { "auto_optimize", n => { AutoOptimize = n.GetEnumValue<global::BunnyApiClient.Models.PullZone.Optimizer.Properties_auto_optimize>(); } },
                { "blur", n => { Blur = n.GetStringValue(); } },
                { "brightness", n => { Brightness = n.GetStringValue(); } },
                { "contrast", n => { Contrast = n.GetStringValue(); } },
                { "crop", n => { Crop = n.GetStringValue(); } },
                { "crop_gravity", n => { CropGravity = n.GetEnumValue<global::BunnyApiClient.Models.PullZone.Optimizer.Properties_crop_gravity>(); } },
                { "flip", n => { Flip = n.GetStringValue(); } },
                { "flop", n => { Flop = n.GetStringValue(); } },
                { "gamma", n => { Gamma = n.GetStringValue(); } },
                { "height", n => { Height = n.GetStringValue(); } },
                { "hue", n => { Hue = n.GetStringValue(); } },
                { "optimizer", n => { Optimizer = n.GetEnumValue<global::BunnyApiClient.Models.PullZone.Optimizer.Properties_optimizer>(); } },
                { "quality", n => { Quality = n.GetStringValue(); } },
                { "saturation", n => { Saturation = n.GetStringValue(); } },
                { "sharpen", n => { Sharpen = n.GetStringValue(); } },
                { "width", n => { Width = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("aspect_ratio", AspectRatio);
            writer.WriteEnumValue<global::BunnyApiClient.Models.PullZone.Optimizer.Properties_auto_optimize>("auto_optimize", AutoOptimize);
            writer.WriteStringValue("blur", Blur);
            writer.WriteStringValue("brightness", Brightness);
            writer.WriteStringValue("contrast", Contrast);
            writer.WriteStringValue("crop", Crop);
            writer.WriteEnumValue<global::BunnyApiClient.Models.PullZone.Optimizer.Properties_crop_gravity>("crop_gravity", CropGravity);
            writer.WriteStringValue("flip", Flip);
            writer.WriteStringValue("flop", Flop);
            writer.WriteStringValue("gamma", Gamma);
            writer.WriteStringValue("height", Height);
            writer.WriteStringValue("hue", Hue);
            writer.WriteEnumValue<global::BunnyApiClient.Models.PullZone.Optimizer.Properties_optimizer>("optimizer", Optimizer);
            writer.WriteStringValue("quality", Quality);
            writer.WriteStringValue("saturation", Saturation);
            writer.WriteStringValue("sharpen", Sharpen);
            writer.WriteStringValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
