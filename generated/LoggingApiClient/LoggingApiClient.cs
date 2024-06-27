// <auto-generated/>
using LoggingApiClient.WithMmWithDdWithYy;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace LoggingApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class LoggingApiClient : BaseCliRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="LoggingApiClient.LoggingApiClient"/> and sets the default values.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRootCommand()
        {
            var command = new RootCommand();
            command.Description = "Instantiates a new LoggingApiClient and sets the default values.";
            command.AddCommand(BuildWithMmWithDdWithYyRbCommand());
            return command;
        }
        /// <summary>
        /// Builds and executes requests for operations under \{mm}-{dd}-{yy}
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWithMmWithDdWithYyRbCommand()
        {
            var command = new Command("with-mm-with-dd-with-yy");
            command.Description = "Builds and executes requests for operations under \\{mm}-{dd}-{yy}";
            var builder = new global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder(PathParameters);
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildWithPullZoneIdLogRbCommand());
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="LoggingApiClient.LoggingApiClient"/> and sets the default values.
        /// </summary>
        public LoggingApiClient() : base("{+baseurl}", new Dictionary<string, object>())
        {
        }
    }
}
