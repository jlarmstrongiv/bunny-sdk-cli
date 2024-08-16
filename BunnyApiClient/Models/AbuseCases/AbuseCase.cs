// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace BunnyApiClient.Models.AbuseCases
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class AbuseCase : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ActualUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActualUrl { get; set; }
#nullable restore
#else
        public string ActualUrl { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DateCreated property</summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>The DateUpdated property</summary>
        public DateTimeOffset? DateUpdated { get; set; }
        /// <summary>The Deadline property</summary>
        public DateTimeOffset? Deadline { get; set; }
        /// <summary>The Id property</summary>
        public long? Id { get; set; }
        /// <summary>The Message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The Path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The PullZoneId property</summary>
        public long? PullZoneId { get; set; }
        /// <summary>The PullZoneName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PullZoneName { get; set; }
#nullable restore
#else
        public string PullZoneName { get; set; }
#endif
        /// <summary>The Status property</summary>
        public double? Status { get; set; }
        /// <summary>The Urls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::BunnyApiClient.Models.AbuseCases.Url>? Urls { get; set; }
#nullable restore
#else
        public List<global::BunnyApiClient.Models.AbuseCases.Url> Urls { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.AbuseCases.AbuseCase"/> and sets the default values.
        /// </summary>
        public AbuseCase()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.AbuseCases.AbuseCase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.AbuseCases.AbuseCase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.AbuseCases.AbuseCase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ActualUrl", n => { ActualUrl = n.GetStringValue(); } },
                { "DateCreated", n => { DateCreated = n.GetDateTimeOffsetValue(); } },
                { "DateUpdated", n => { DateUpdated = n.GetDateTimeOffsetValue(); } },
                { "Deadline", n => { Deadline = n.GetDateTimeOffsetValue(); } },
                { "Id", n => { Id = n.GetLongValue(); } },
                { "Message", n => { Message = n.GetStringValue(); } },
                { "Path", n => { Path = n.GetStringValue(); } },
                { "PullZoneId", n => { PullZoneId = n.GetLongValue(); } },
                { "PullZoneName", n => { PullZoneName = n.GetStringValue(); } },
                { "Status", n => { Status = n.GetDoubleValue(); } },
                { "Urls", n => { Urls = n.GetCollectionOfObjectValues<global::BunnyApiClient.Models.AbuseCases.Url>(global::BunnyApiClient.Models.AbuseCases.Url.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ActualUrl", ActualUrl);
            writer.WriteDateTimeOffsetValue("DateCreated", DateCreated);
            writer.WriteDateTimeOffsetValue("DateUpdated", DateUpdated);
            writer.WriteDateTimeOffsetValue("Deadline", Deadline);
            writer.WriteLongValue("Id", Id);
            writer.WriteStringValue("Message", Message);
            writer.WriteStringValue("Path", Path);
            writer.WriteLongValue("PullZoneId", PullZoneId);
            writer.WriteStringValue("PullZoneName", PullZoneName);
            writer.WriteDoubleValue("Status", Status);
            writer.WriteCollectionOfObjectValues<global::BunnyApiClient.Models.AbuseCases.Url>("Urls", Urls);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
