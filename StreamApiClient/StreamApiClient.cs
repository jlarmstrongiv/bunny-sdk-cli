// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using StreamApiClient.Library;
using StreamApiClient.OEmbed;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System;
namespace StreamApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StreamApiClient : BaseCliRequestBuilder
    {
        /// <summary>
        /// The library property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLibraryNavCommand()
        {
            var command = new Command("library");
            command.Description = "The library property";
            var builder = new global::StreamApiClient.Library.LibraryRequestBuilder(PathParameters);
            var nonExecCommands = new List<Command>();
            var cmds = builder.BuildCommand();
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The OEmbed property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOEmbedNavCommand()
        {
            var command = new Command("o-embed");
            command.Description = "The OEmbed property";
            var builder = new global::StreamApiClient.OEmbed.OEmbedRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.StreamApiClient"/> and sets the default values.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRootCommand()
        {
            var command = new RootCommand();
            command.Description = "Instantiates a new StreamApiClient and sets the default values.";
            command.AddCommand(BuildLibraryNavCommand());
            command.AddCommand(BuildOEmbedNavCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.StreamApiClient"/> and sets the default values.
        /// </summary>
        public StreamApiClient() : base("{+baseurl}", new Dictionary<string, object>())
        {
        }
    }
}
#pragma warning restore CS0618
