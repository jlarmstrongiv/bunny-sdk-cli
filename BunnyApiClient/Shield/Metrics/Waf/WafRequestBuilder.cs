// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Shield.Metrics.Waf.Blocked;
using BunnyApiClient.Shield.Metrics.Waf.Logged;
using BunnyApiClient.Shield.Metrics.Waf.Processed;
using BunnyApiClient.Shield.Metrics.Waf.Triggered;
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
namespace BunnyApiClient.Shield.Metrics.Waf
{
    /// <summary>
    /// Builds and executes requests for operations under \shield\metrics\waf
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WafRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The blocked property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBlockedNavCommand()
        {
            var command = new Command("blocked");
            command.Description = "The blocked property";
            var builder = new global::BunnyApiClient.Shield.Metrics.Waf.Blocked.BlockedRequestBuilder(PathParameters);
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
        /// The logged property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLoggedNavCommand()
        {
            var command = new Command("logged");
            command.Description = "The logged property";
            var builder = new global::BunnyApiClient.Shield.Metrics.Waf.Logged.LoggedRequestBuilder(PathParameters);
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
        /// The processed property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildProcessedNavCommand()
        {
            var command = new Command("processed");
            command.Description = "The processed property";
            var builder = new global::BunnyApiClient.Shield.Metrics.Waf.Processed.ProcessedRequestBuilder(PathParameters);
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
        /// The triggered property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTriggeredNavCommand()
        {
            var command = new Command("triggered");
            command.Description = "The triggered property";
            var builder = new global::BunnyApiClient.Shield.Metrics.Waf.Triggered.TriggeredRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.Metrics.Waf.WafRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WafRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/shield/metrics/waf", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Shield.Metrics.Waf.WafRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WafRequestBuilder(string rawUrl) : base("{+baseurl}/shield/metrics/waf", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618