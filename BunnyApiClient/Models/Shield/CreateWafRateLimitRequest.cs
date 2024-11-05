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
    public partial class CreateWafRateLimitRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ruleConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel? RuleConfiguration { get; set; }
#nullable restore
#else
        public global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel RuleConfiguration { get; set; }
#endif
        /// <summary>The ruleDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleDescription { get; set; }
#nullable restore
#else
        public string RuleDescription { get; set; }
#endif
        /// <summary>The ruleName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleName { get; set; }
#nullable restore
#else
        public string RuleName { get; set; }
#endif
        /// <summary>The shieldZoneId property</summary>
        public long? ShieldZoneId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.Shield.CreateWafRateLimitRequest"/> and sets the default values.
        /// </summary>
        public CreateWafRateLimitRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.Shield.CreateWafRateLimitRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Shield.CreateWafRateLimitRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Shield.CreateWafRateLimitRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ruleConfiguration", n => { RuleConfiguration = n.GetObjectValue<global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel>(global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel.CreateFromDiscriminatorValue); } },
                { "ruleDescription", n => { RuleDescription = n.GetStringValue(); } },
                { "ruleName", n => { RuleName = n.GetStringValue(); } },
                { "shieldZoneId", n => { ShieldZoneId = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel>("ruleConfiguration", RuleConfiguration);
            writer.WriteStringValue("ruleDescription", RuleDescription);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteLongValue("shieldZoneId", ShieldZoneId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
