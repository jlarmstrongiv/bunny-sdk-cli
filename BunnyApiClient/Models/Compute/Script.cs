// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Models.PullZone;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.Compute
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Script : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CurrentReleaseId property</summary>
        public long? CurrentReleaseId { get; private set; }
        /// <summary>The DefaultHostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultHostname { get; private set; }
#nullable restore
#else
        public string DefaultHostname { get; private set; }
#endif
        /// <summary>The Deleted property</summary>
        public bool? Deleted { get; private set; }
        /// <summary>The EdgeScriptVariables property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.Compute.EdgeScriptVariable>? EdgeScriptVariables { get; private set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.Compute.EdgeScriptVariable> EdgeScriptVariables { get; private set; }
#endif
        /// <summary>The Id property</summary>
        public long? Id { get; private set; }
        /// <summary>The LastModified property</summary>
        public DateTimeOffset? LastModified { get; private set; }
        /// <summary>The LinkedPullZones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.PullZone.PullZone>? LinkedPullZones { get; private set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.PullZone.PullZone> LinkedPullZones { get; private set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ScriptType property</summary>
        public double? ScriptType { get; set; }
        /// <summary>The SystemHostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemHostname { get; private set; }
#nullable restore
#else
        public string SystemHostname { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.Compute.Script"/> and sets the default values.
        /// </summary>
        public Script()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.Compute.Script"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Compute.Script CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Compute.Script();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CurrentReleaseId", n => { CurrentReleaseId = n.GetLongValue(); } },
                { "DefaultHostname", n => { DefaultHostname = n.GetStringValue(); } },
                { "Deleted", n => { Deleted = n.GetBoolValue(); } },
                { "EdgeScriptVariables", n => { EdgeScriptVariables = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.Compute.EdgeScriptVariable>(global::BunnyApiClient.Models.Compute.EdgeScriptVariable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "LastModified", n => { LastModified = n.GetDateTimeOffsetValue(); } },
                { "LinkedPullZones", n => { LinkedPullZones = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.PullZone.PullZone>(global::BunnyApiClient.Models.PullZone.PullZone.CreateFromDiscriminatorValue)?.AsList(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "ScriptType", n => { ScriptType = n.GetDoubleValue(); } },
                { "SystemHostname", n => { SystemHostname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Name", Name);
            writer.WriteDoubleValue("ScriptType", ScriptType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
