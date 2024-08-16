// <auto-generated/>
using BunnyApiClient.Dmca.Item;
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
namespace BunnyApiClient.Dmca
{
    /// <summary>
    /// Builds and executes requests for operations under \dmca
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class DmcaRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the BunnyApiClient.dmca.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::BunnyApiClient.Dmca.Item.DmcaItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildGetCommand());
            commands.Add(builder.BuildResolveNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dmca.DmcaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DmcaRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/dmca", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Dmca.DmcaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DmcaRequestBuilder(string rawUrl) : base("{+baseurl}/dmca", rawUrl)
        {
        }
    }
}
