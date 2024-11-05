// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.Compute;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Compute.Script
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ScriptGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CurrentPage property</summary>
        public int? CurrentPage { get; set; }
        /// <summary>The HasMoreItems property</summary>
        public bool? HasMoreItems { get; set; }
        /// <summary>The Items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.Compute.Script>? Items { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.Compute.Script> Items { get; set; }
#endif
        /// <summary>The TotalItems property</summary>
        public int? TotalItems { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.ScriptGetResponse"/> and sets the default values.
        /// </summary>
        public ScriptGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Compute.Script.ScriptGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Compute.Script.ScriptGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Compute.Script.ScriptGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CurrentPage", n => { CurrentPage = n.GetIntValue(); } },
                { "HasMoreItems", n => { HasMoreItems = n.GetBoolValue(); } },
                { "Items", n => { Items = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.Compute.Script>(global::BunnyApiClient.Models.Compute.Script.CreateFromDiscriminatorValue)?.AsList(); } },
                { "TotalItems", n => { TotalItems = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("CurrentPage", CurrentPage);
            writer.WriteBoolValue("HasMoreItems", HasMoreItems);
            writer.WriteCollectionOfObjectValues<global::BunnyApiClient.Models.Compute.Script>("Items", Items);
            writer.WriteIntValue("TotalItems", TotalItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
