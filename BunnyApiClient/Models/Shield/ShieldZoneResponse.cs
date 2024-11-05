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
    public partial class ShieldZoneResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The customWafRulesLimit property</summary>
        public int? CustomWafRulesLimit { get; set; }
        /// <summary>The dDoSChallengeWindow property</summary>
        public int? DDoSChallengeWindow { get; set; }
        /// <summary>The dDoSShieldSensitivity property</summary>
        public double? DDoSShieldSensitivity { get; set; }
        /// <summary>The learningMode property</summary>
        public bool? LearningMode { get; set; }
        /// <summary>The learningModeUntil property</summary>
        public DateTimeOffset? LearningModeUntil { get; set; }
        /// <summary>The planType property</summary>
        public double? PlanType { get; set; }
        /// <summary>The pullZoneId property</summary>
        public long? PullZoneId { get; set; }
        /// <summary>The rateLimitRulesLimit property</summary>
        public int? RateLimitRulesLimit { get; set; }
        /// <summary>The shieldZoneId property</summary>
        public long? ShieldZoneId { get; set; }
        /// <summary>The wafDisabledRuleGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WafDisabledRuleGroups { get; set; }
#nullable restore
#else
        public List<string> WafDisabledRuleGroups { get; set; }
#endif
        /// <summary>The wafDisabledRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WafDisabledRules { get; set; }
#nullable restore
#else
        public List<string> WafDisabledRules { get; set; }
#endif
        /// <summary>The wafEnabled property</summary>
        public bool? WafEnabled { get; set; }
        /// <summary>The wafEngineConfig property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.Shield.PullZoneWafConfigVariableModel>? WafEngineConfig { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.Shield.PullZoneWafConfigVariableModel> WafEngineConfig { get; set; }
#endif
        /// <summary>The wafExecutionMode property</summary>
        public double? WafExecutionMode { get; set; }
        /// <summary>The wafLogOnlyRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WafLogOnlyRules { get; set; }
#nullable restore
#else
        public List<string> WafLogOnlyRules { get; set; }
#endif
        /// <summary>The wafProfileId property</summary>
        public int? WafProfileId { get; set; }
        /// <summary>The wafRequestHeaderLoggingEnabled property</summary>
        public bool? WafRequestHeaderLoggingEnabled { get; set; }
        /// <summary>The wafRequestIgnoredHeaders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WafRequestIgnoredHeaders { get; set; }
#nullable restore
#else
        public List<string> WafRequestIgnoredHeaders { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.Shield.ShieldZoneResponse"/> and sets the default values.
        /// </summary>
        public ShieldZoneResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.Shield.ShieldZoneResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Shield.ShieldZoneResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Shield.ShieldZoneResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "customWafRulesLimit", n => { CustomWafRulesLimit = n.GetIntValue(); } },
                { "dDoSChallengeWindow", n => { DDoSChallengeWindow = n.GetIntValue(); } },
                { "dDoSShieldSensitivity", n => { DDoSShieldSensitivity = n.GetDoubleValue(); } },
                { "learningMode", n => { LearningMode = n.GetBoolValue(); } },
                { "learningModeUntil", n => { LearningModeUntil = n.GetDateTimeOffsetValue(); } },
                { "planType", n => { PlanType = n.GetDoubleValue(); } },
                { "pullZoneId", n => { PullZoneId = n.GetLongValue(); } },
                { "rateLimitRulesLimit", n => { RateLimitRulesLimit = n.GetIntValue(); } },
                { "shieldZoneId", n => { ShieldZoneId = n.GetLongValue(); } },
                { "wafDisabledRuleGroups", n => { WafDisabledRuleGroups = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "wafDisabledRules", n => { WafDisabledRules = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "wafEnabled", n => { WafEnabled = n.GetBoolValue(); } },
                { "wafEngineConfig", n => { WafEngineConfig = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.Shield.PullZoneWafConfigVariableModel>(global::BunnyApiClient.Models.Shield.PullZoneWafConfigVariableModel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "wafExecutionMode", n => { WafExecutionMode = n.GetDoubleValue(); } },
                { "wafLogOnlyRules", n => { WafLogOnlyRules = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "wafProfileId", n => { WafProfileId = n.GetIntValue(); } },
                { "wafRequestHeaderLoggingEnabled", n => { WafRequestHeaderLoggingEnabled = n.GetBoolValue(); } },
                { "wafRequestIgnoredHeaders", n => { WafRequestIgnoredHeaders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("customWafRulesLimit", CustomWafRulesLimit);
            writer.WriteIntValue("dDoSChallengeWindow", DDoSChallengeWindow);
            writer.WriteDoubleValue("dDoSShieldSensitivity", DDoSShieldSensitivity);
            writer.WriteBoolValue("learningMode", LearningMode);
            writer.WriteDateTimeOffsetValue("learningModeUntil", LearningModeUntil);
            writer.WriteDoubleValue("planType", PlanType);
            writer.WriteLongValue("pullZoneId", PullZoneId);
            writer.WriteIntValue("rateLimitRulesLimit", RateLimitRulesLimit);
            writer.WriteLongValue("shieldZoneId", ShieldZoneId);
            writer.WriteCollectionOfPrimitiveValues<string>("wafDisabledRuleGroups", WafDisabledRuleGroups);
            writer.WriteCollectionOfPrimitiveValues<string>("wafDisabledRules", WafDisabledRules);
            writer.WriteBoolValue("wafEnabled", WafEnabled);
            writer.WriteCollectionOfObjectValues<global::BunnyApiClient.Models.Shield.PullZoneWafConfigVariableModel>("wafEngineConfig", WafEngineConfig);
            writer.WriteDoubleValue("wafExecutionMode", WafExecutionMode);
            writer.WriteCollectionOfPrimitiveValues<string>("wafLogOnlyRules", WafLogOnlyRules);
            writer.WriteIntValue("wafProfileId", WafProfileId);
            writer.WriteBoolValue("wafRequestHeaderLoggingEnabled", WafRequestHeaderLoggingEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("wafRequestIgnoredHeaders", WafRequestIgnoredHeaders);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618