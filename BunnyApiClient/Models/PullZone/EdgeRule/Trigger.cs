// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.PullZone.EdgeRule
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class Trigger : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The trigger parameter 1. The value depends on the type of trigger.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Parameter1 { get; set; }
#nullable restore
#else
        public string Parameter1 { get; set; }
#endif
        /// <summary>The list of pattern matches that will trigger the edge rule</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PatternMatches { get; set; }
#nullable restore
#else
        public List<string> PatternMatches { get; set; }
#endif
        /// <summary>The PatternMatchingType property</summary>
        public double? PatternMatchingType { get; set; }
        /// <summary>The Type property</summary>
        public double? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger"/> and sets the default values.
        /// </summary>
        public Trigger()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.PullZone.EdgeRule.Trigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Parameter1", n => { Parameter1 = n.GetStringValue(); } },
                { "PatternMatches", n => { PatternMatches = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "PatternMatchingType", n => { PatternMatchingType = n.GetDoubleValue(); } },
                { "Type", n => { Type = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Parameter1", Parameter1);
            writer.WriteCollectionOfPrimitiveValues<string>("PatternMatches", PatternMatches);
            writer.WriteDoubleValue("PatternMatchingType", PatternMatchingType);
            writer.WriteDoubleValue("Type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
