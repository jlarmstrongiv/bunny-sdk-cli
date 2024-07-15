// <auto-generated/>
using EdgeStorageApiClient.Item.Item;
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
namespace EdgeStorageApiClient.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \{storageZoneName}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class WithStorageZoneNameItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the EdgeStorageApiClient.item.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::EdgeStorageApiClient.Item.Item.WithPathItemRequestBuilder(PathParameters);
            var cmds = builder.BuildCommand();
            executables.AddRange(cmds.Item1);
            commands.AddRange(cmds.Item2);
            executables.Add(builder.BuildListCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WithStorageZoneNameItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/{storageZoneName}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithStorageZoneNameItemRequestBuilder(string rawUrl) : base("{+baseurl}/{storageZoneName}", rawUrl)
        {
        }
    }
}
