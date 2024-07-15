// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class SetEdgeRuleEnabledPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Id property</summary>
        public long? Id { get; set; }
        /// <summary>The Value property</summary>
        public bool? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody"/> and sets the default values.
        /// </summary>
        public SetEdgeRuleEnabledPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Pullzone.Item.Edgerules.Item.SetEdgeRuleEnabled.SetEdgeRuleEnabledPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Id", n => { Id = n.GetLongValue(); } },
                { "Value", n => { Value = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("Id", Id);
            writer.WriteBoolValue("Value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}