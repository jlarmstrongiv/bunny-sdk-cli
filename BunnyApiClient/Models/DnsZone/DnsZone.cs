// <auto-generated/>
using BunnyApiClient.Models.DnsZone.UpdateDnsRecord;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.DnsZone
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class DnsZone : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CustomNameserversEnabled property</summary>
        public bool? CustomNameserversEnabled { get; set; }
        /// <summary>The DateCreated property</summary>
        public DateTimeOffset? DateCreated { get; private set; }
        /// <summary>The DateModified property</summary>
        public DateTimeOffset? DateModified { get; private set; }
        /// <summary>The Domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; private set; }
#nullable restore
#else
        public string Domain { get; private set; }
#endif
        /// <summary>The Id property</summary>
        public long? Id { get; private set; }
        /// <summary>The LogAnonymizationType property</summary>
        public double? LogAnonymizationType { get; set; }
        /// <summary>The LoggingEnabled property</summary>
        public bool? LoggingEnabled { get; set; }
        /// <summary>Determines if the log anonymization should be enabled</summary>
        public bool? LoggingIPAnonymizationEnabled { get; set; }
        /// <summary>The Nameserver1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nameserver1 { get; set; }
#nullable restore
#else
        public string Nameserver1 { get; set; }
#endif
        /// <summary>The Nameserver2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nameserver2 { get; set; }
#nullable restore
#else
        public string Nameserver2 { get; set; }
#endif
        /// <summary>The NameserversDetected property</summary>
        public bool? NameserversDetected { get; private set; }
        /// <summary>The NameserversNextCheck property</summary>
        public DateTimeOffset? NameserversNextCheck { get; private set; }
        /// <summary>The Records property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.DnsRecord>? Records { get; private set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.DnsRecord> Records { get; private set; }
#endif
        /// <summary>The SoaEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SoaEmail { get; set; }
#nullable restore
#else
        public string SoaEmail { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.DnsZone.DnsZone"/> and sets the default values.
        /// </summary>
        public DnsZone()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.DnsZone.DnsZone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.DnsZone.DnsZone CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.DnsZone.DnsZone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "CustomNameserversEnabled", n => { CustomNameserversEnabled = n.GetBoolValue(); } },
                { "DateCreated", n => { DateCreated = n.GetDateTimeOffsetValue(); } },
                { "DateModified", n => { DateModified = n.GetDateTimeOffsetValue(); } },
                { "Domain", n => { Domain = n.GetStringValue(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "LogAnonymizationType", n => { LogAnonymizationType = n.GetDoubleValue(); } },
                { "LoggingEnabled", n => { LoggingEnabled = n.GetBoolValue(); } },
                { "LoggingIPAnonymizationEnabled", n => { LoggingIPAnonymizationEnabled = n.GetBoolValue(); } },
                { "Nameserver1", n => { Nameserver1 = n.GetStringValue(); } },
                { "Nameserver2", n => { Nameserver2 = n.GetStringValue(); } },
                { "NameserversDetected", n => { NameserversDetected = n.GetBoolValue(); } },
                { "NameserversNextCheck", n => { NameserversNextCheck = n.GetDateTimeOffsetValue(); } },
                { "Records", n => { Records = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.DnsRecord>(global::BunnyApiClient.Models.DnsZone.UpdateDnsRecord.DnsRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "SoaEmail", n => { SoaEmail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("CustomNameserversEnabled", CustomNameserversEnabled);
            writer.WriteDoubleValue("LogAnonymizationType", LogAnonymizationType);
            writer.WriteBoolValue("LoggingEnabled", LoggingEnabled);
            writer.WriteBoolValue("LoggingIPAnonymizationEnabled", LoggingIPAnonymizationEnabled);
            writer.WriteStringValue("Nameserver1", Nameserver1);
            writer.WriteStringValue("Nameserver2", Nameserver2);
            writer.WriteStringValue("SoaEmail", SoaEmail);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
