// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.Shield
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CreateShieldZoneRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The pullZoneId property</summary>
        public long? PullZoneId { get; set; }
        /// <summary>The shieldZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::BunnyApiClient.Models.Shield.ShieldZoneRequest? ShieldZone { get; set; }
#nullable restore
#else
        public global::BunnyApiClient.Models.Shield.ShieldZoneRequest ShieldZone { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.Shield.CreateShieldZoneRequest"/> and sets the default values.
        /// </summary>
        public CreateShieldZoneRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.Shield.CreateShieldZoneRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Shield.CreateShieldZoneRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Shield.CreateShieldZoneRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "pullZoneId", n => { PullZoneId = n.GetLongValue(); } },
                { "shieldZone", n => { ShieldZone = n.GetObjectValue<global::BunnyApiClient.Models.Shield.ShieldZoneRequest>(global::BunnyApiClient.Models.Shield.ShieldZoneRequest.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("pullZoneId", PullZoneId);
            writer.WriteObjectValue<global::BunnyApiClient.Models.Shield.ShieldZoneRequest>("shieldZone", ShieldZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618