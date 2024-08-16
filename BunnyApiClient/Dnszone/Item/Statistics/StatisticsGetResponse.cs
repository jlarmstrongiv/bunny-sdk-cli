// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Dnszone.Item.Statistics
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class StatisticsGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The QueriesByTypeChart property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesByTypeChart? QueriesByTypeChart { get; set; }
#nullable restore
#else
        public global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesByTypeChart QueriesByTypeChart { get; set; }
#endif
        /// <summary>The QueriesServedChart property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesServedChart? QueriesServedChart { get; set; }
#nullable restore
#else
        public global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesServedChart QueriesServedChart { get; set; }
#endif
        /// <summary>The TotalQueriesServed property</summary>
        public long? TotalQueriesServed { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse"/> and sets the default values.
        /// </summary>
        public StatisticsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "QueriesByTypeChart", n => { QueriesByTypeChart = n.GetObjectValue<global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesByTypeChart>(global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesByTypeChart.CreateFromDiscriminatorValue); } },
                { "QueriesServedChart", n => { QueriesServedChart = n.GetObjectValue<global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesServedChart>(global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesServedChart.CreateFromDiscriminatorValue); } },
                { "TotalQueriesServed", n => { TotalQueriesServed = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesByTypeChart>("QueriesByTypeChart", QueriesByTypeChart);
            writer.WriteObjectValue<global::BunnyApiClient.Dnszone.Item.Statistics.StatisticsGetResponse_QueriesServedChart>("QueriesServedChart", QueriesServedChart);
            writer.WriteLongValue("TotalQueriesServed", TotalQueriesServed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
