// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace BunnyApiClient.Models.Region.RegionList
{
    #pragma warning disable CS1591
    public class Region : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AllowLatencyRouting property</summary>
        public bool? AllowLatencyRouting { get; set; }
        /// <summary>The ContinentCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContinentCode { get; set; }
#nullable restore
#else
        public string ContinentCode { get; set; }
#endif
        /// <summary>The CountryCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The Id property</summary>
        public long? Id { get; set; }
        /// <summary>The Latitude property</summary>
        public double? Latitude { get; set; }
        /// <summary>The Longitude property</summary>
        public double? Longitude { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The PricePerGigabyte property</summary>
        public double? PricePerGigabyte { get; set; }
        /// <summary>The RegionCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionCode { get; set; }
#nullable restore
#else
        public string RegionCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Models.Region.RegionList.Region"/> and sets the default values.
        /// </summary>
        public Region()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BunnyApiClient.Models.Region.RegionList.Region"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Region.RegionList.Region CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Region.RegionList.Region();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "AllowLatencyRouting", n => { AllowLatencyRouting = n.GetBoolValue(); } },
                { "ContinentCode", n => { ContinentCode = n.GetStringValue(); } },
                { "CountryCode", n => { CountryCode = n.GetStringValue(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "Latitude", n => { Latitude = n.GetDoubleValue(); } },
                { "Longitude", n => { Longitude = n.GetDoubleValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "PricePerGigabyte", n => { PricePerGigabyte = n.GetDoubleValue(); } },
                { "RegionCode", n => { RegionCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("AllowLatencyRouting", AllowLatencyRouting);
            writer.WriteStringValue("ContinentCode", ContinentCode);
            writer.WriteStringValue("CountryCode", CountryCode);
            writer.WriteLongValue("Id", Id);
            writer.WriteDoubleValue("Latitude", Latitude);
            writer.WriteDoubleValue("Longitude", Longitude);
            writer.WriteStringValue("Name", Name);
            writer.WriteDoubleValue("PricePerGigabyte", PricePerGigabyte);
            writer.WriteStringValue("RegionCode", RegionCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
