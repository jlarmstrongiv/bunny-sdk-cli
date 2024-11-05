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
    public partial class CreateWafRateLimitRuleModel_variableTypes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ARGS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ARGS { get; set; }
#nullable restore
#else
        public string ARGS { get; set; }
#endif
        /// <summary>The ARGS_COMBINED_SIZE property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ARGSCOMBINEDSIZE { get; set; }
#nullable restore
#else
        public string ARGSCOMBINEDSIZE { get; set; }
#endif
        /// <summary>The ARGS_GET property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ARGSGET { get; set; }
#nullable restore
#else
        public string ARGSGET { get; set; }
#endif
        /// <summary>The ARGS_GET_NAMES property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ARGSGETNAMES { get; set; }
#nullable restore
#else
        public string ARGSGETNAMES { get; set; }
#endif
        /// <summary>The ARGS_POST property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ARGSPOST { get; set; }
#nullable restore
#else
        public string ARGSPOST { get; set; }
#endif
        /// <summary>The ARGS_POST_NAMES property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ARGSPOSTNAMES { get; set; }
#nullable restore
#else
        public string ARGSPOSTNAMES { get; set; }
#endif
        /// <summary>The FILES_NAMES property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FILESNAMES { get; set; }
#nullable restore
#else
        public string FILESNAMES { get; set; }
#endif
        /// <summary>The GEO property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GEO { get; set; }
#nullable restore
#else
        public string GEO { get; set; }
#endif
        /// <summary>The QUERY_STRING property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QUERYSTRING { get; set; }
#nullable restore
#else
        public string QUERYSTRING { get; set; }
#endif
        /// <summary>The REMOTE_ADDR property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REMOTEADDR { get; set; }
#nullable restore
#else
        public string REMOTEADDR { get; set; }
#endif
        /// <summary>The REQUEST_BASENAME property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTBASENAME { get; set; }
#nullable restore
#else
        public string REQUESTBASENAME { get; set; }
#endif
        /// <summary>The REQUEST_BODY property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTBODY { get; set; }
#nullable restore
#else
        public string REQUESTBODY { get; set; }
#endif
        /// <summary>The REQUEST_COOKIES property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTCOOKIES { get; set; }
#nullable restore
#else
        public string REQUESTCOOKIES { get; set; }
#endif
        /// <summary>The REQUEST_COOKIES_NAMES property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTCOOKIESNAMES { get; set; }
#nullable restore
#else
        public string REQUESTCOOKIESNAMES { get; set; }
#endif
        /// <summary>The REQUEST_FILENAME property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTFILENAME { get; set; }
#nullable restore
#else
        public string REQUESTFILENAME { get; set; }
#endif
        /// <summary>The REQUEST_HEADERS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTHEADERS { get; set; }
#nullable restore
#else
        public string REQUESTHEADERS { get; set; }
#endif
        /// <summary>The REQUEST_HEADERS_NAMES property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTHEADERSNAMES { get; set; }
#nullable restore
#else
        public string REQUESTHEADERSNAMES { get; set; }
#endif
        /// <summary>The REQUEST_LINE property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTLINE { get; set; }
#nullable restore
#else
        public string REQUESTLINE { get; set; }
#endif
        /// <summary>The REQUEST_METHOD property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTMETHOD { get; set; }
#nullable restore
#else
        public string REQUESTMETHOD { get; set; }
#endif
        /// <summary>The REQUEST_PROTOCOL property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTPROTOCOL { get; set; }
#nullable restore
#else
        public string REQUESTPROTOCOL { get; set; }
#endif
        /// <summary>The REQUEST_URI property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTURI { get; set; }
#nullable restore
#else
        public string REQUESTURI { get; set; }
#endif
        /// <summary>The REQUEST_URI_RAW property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? REQUESTURIRAW { get; set; }
#nullable restore
#else
        public string REQUESTURIRAW { get; set; }
#endif
        /// <summary>The RESPONSE_BODY property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RESPONSEBODY { get; set; }
#nullable restore
#else
        public string RESPONSEBODY { get; set; }
#endif
        /// <summary>The RESPONSE_HEADERS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RESPONSEHEADERS { get; set; }
#nullable restore
#else
        public string RESPONSEHEADERS { get; set; }
#endif
        /// <summary>The RESPONSE_STATUS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RESPONSESTATUS { get; set; }
#nullable restore
#else
        public string RESPONSESTATUS { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel_variableTypes"/> and sets the default values.
        /// </summary>
        public CreateWafRateLimitRuleModel_variableTypes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel_variableTypes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel_variableTypes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::BunnyApiClient.Models.Shield.CreateWafRateLimitRuleModel_variableTypes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ARGS", n => { ARGS = n.GetStringValue(); } },
                { "ARGS_COMBINED_SIZE", n => { ARGSCOMBINEDSIZE = n.GetStringValue(); } },
                { "ARGS_GET", n => { ARGSGET = n.GetStringValue(); } },
                { "ARGS_GET_NAMES", n => { ARGSGETNAMES = n.GetStringValue(); } },
                { "ARGS_POST", n => { ARGSPOST = n.GetStringValue(); } },
                { "ARGS_POST_NAMES", n => { ARGSPOSTNAMES = n.GetStringValue(); } },
                { "FILES_NAMES", n => { FILESNAMES = n.GetStringValue(); } },
                { "GEO", n => { GEO = n.GetStringValue(); } },
                { "QUERY_STRING", n => { QUERYSTRING = n.GetStringValue(); } },
                { "REMOTE_ADDR", n => { REMOTEADDR = n.GetStringValue(); } },
                { "REQUEST_BASENAME", n => { REQUESTBASENAME = n.GetStringValue(); } },
                { "REQUEST_BODY", n => { REQUESTBODY = n.GetStringValue(); } },
                { "REQUEST_COOKIES", n => { REQUESTCOOKIES = n.GetStringValue(); } },
                { "REQUEST_COOKIES_NAMES", n => { REQUESTCOOKIESNAMES = n.GetStringValue(); } },
                { "REQUEST_FILENAME", n => { REQUESTFILENAME = n.GetStringValue(); } },
                { "REQUEST_HEADERS", n => { REQUESTHEADERS = n.GetStringValue(); } },
                { "REQUEST_HEADERS_NAMES", n => { REQUESTHEADERSNAMES = n.GetStringValue(); } },
                { "REQUEST_LINE", n => { REQUESTLINE = n.GetStringValue(); } },
                { "REQUEST_METHOD", n => { REQUESTMETHOD = n.GetStringValue(); } },
                { "REQUEST_PROTOCOL", n => { REQUESTPROTOCOL = n.GetStringValue(); } },
                { "REQUEST_URI", n => { REQUESTURI = n.GetStringValue(); } },
                { "REQUEST_URI_RAW", n => { REQUESTURIRAW = n.GetStringValue(); } },
                { "RESPONSE_BODY", n => { RESPONSEBODY = n.GetStringValue(); } },
                { "RESPONSE_HEADERS", n => { RESPONSEHEADERS = n.GetStringValue(); } },
                { "RESPONSE_STATUS", n => { RESPONSESTATUS = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ARGS", ARGS);
            writer.WriteStringValue("ARGS_COMBINED_SIZE", ARGSCOMBINEDSIZE);
            writer.WriteStringValue("ARGS_GET", ARGSGET);
            writer.WriteStringValue("ARGS_GET_NAMES", ARGSGETNAMES);
            writer.WriteStringValue("ARGS_POST", ARGSPOST);
            writer.WriteStringValue("ARGS_POST_NAMES", ARGSPOSTNAMES);
            writer.WriteStringValue("FILES_NAMES", FILESNAMES);
            writer.WriteStringValue("GEO", GEO);
            writer.WriteStringValue("QUERY_STRING", QUERYSTRING);
            writer.WriteStringValue("REMOTE_ADDR", REMOTEADDR);
            writer.WriteStringValue("REQUEST_BASENAME", REQUESTBASENAME);
            writer.WriteStringValue("REQUEST_BODY", REQUESTBODY);
            writer.WriteStringValue("REQUEST_COOKIES", REQUESTCOOKIES);
            writer.WriteStringValue("REQUEST_COOKIES_NAMES", REQUESTCOOKIESNAMES);
            writer.WriteStringValue("REQUEST_FILENAME", REQUESTFILENAME);
            writer.WriteStringValue("REQUEST_HEADERS", REQUESTHEADERS);
            writer.WriteStringValue("REQUEST_HEADERS_NAMES", REQUESTHEADERSNAMES);
            writer.WriteStringValue("REQUEST_LINE", REQUESTLINE);
            writer.WriteStringValue("REQUEST_METHOD", REQUESTMETHOD);
            writer.WriteStringValue("REQUEST_PROTOCOL", REQUESTPROTOCOL);
            writer.WriteStringValue("REQUEST_URI", REQUESTURI);
            writer.WriteStringValue("REQUEST_URI_RAW", REQUESTURIRAW);
            writer.WriteStringValue("RESPONSE_BODY", RESPONSEBODY);
            writer.WriteStringValue("RESPONSE_HEADERS", RESPONSEHEADERS);
            writer.WriteStringValue("RESPONSE_STATUS", RESPONSESTATUS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618