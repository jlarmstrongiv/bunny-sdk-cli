// <auto-generated/>
#pragma warning disable CS0618
using EdgeStorageApiClient.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System;
namespace EdgeStorageApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EdgeStorageApiClient : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the EdgeStorageApiClient.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::EdgeStorageApiClient.Item.WithStorageZoneNameItemRequestBuilder(PathParameters);
            var cmds = builder.BuildCommand();
            executables.AddRange(cmds.Item1);
            commands.AddRange(cmds.Item2);
            commands.Add(builder.BuildWithPathSlashRbCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::EdgeStorageApiClient.EdgeStorageApiClient"/> and sets the default values.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRootCommand()
        {
            var command = new RootCommand();
            command.Description = "Instantiates a new EdgeStorageApiClient and sets the default values.";
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            var cmds = BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            command.AddCommand(BuildWithStorageZoneNameSlashRbCommand());
            return command;
        }
        /// <summary>
        /// Builds and executes requests for operations under \{storageZoneName}\
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWithStorageZoneNameSlashRbCommand()
        {
            var command = new Command("with-storage-zone-name-slash");
            command.Description = "Builds and executes requests for operations under /{storageZoneName}/";
            var builder = new global::EdgeStorageApiClient.Item.WithStorageZoneNameSlashRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::EdgeStorageApiClient.EdgeStorageApiClient"/> and sets the default values.
        /// </summary>
        public EdgeStorageApiClient() : base("{+baseurl}", new Dictionary<string, object>())
        {
        }
    }
}
#pragma warning restore CS0618
