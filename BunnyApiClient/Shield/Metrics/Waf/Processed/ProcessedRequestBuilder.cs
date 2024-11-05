// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Shield.Metrics.Waf.Processed.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Shield.Metrics.Waf.Processed
{
    /// <summary>
    /// Builds and executes requests for operations under \shield\metrics\waf\processed
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProcessedRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the BunnyApiClient.shield.metrics.waf.processed.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var builder = new global::BunnyApiClient.Shield.Metrics.Waf.Processed.Item.WithShieldZoneItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildGetCommand());
            return new(executables, new(0));
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.Metrics.Waf.Processed.ProcessedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ProcessedRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/shield/metrics/waf/processed", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.Metrics.Waf.Processed.ProcessedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ProcessedRequestBuilder(string rawUrl) : base("{+baseurl}/shield/metrics/waf/processed", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618