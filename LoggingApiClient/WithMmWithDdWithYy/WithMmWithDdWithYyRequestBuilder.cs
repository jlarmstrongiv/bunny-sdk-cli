// <auto-generated/>
#pragma warning disable CS0618
using LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog;
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
namespace LoggingApiClient.WithMmWithDdWithYy
{
    /// <summary>
    /// Builds and executes requests for operations under \{mm}-{dd}-{yy}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithMmWithDdWithYyRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Builds and executes requests for operations under \{mm}-{dd}-{yy}\{pullZoneId}.log
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildWithPullZoneIdLogRbCommand()
        {
            var command = new Command("with-pull-zone-id-log");
            command.Description = "Builds and executes requests for operations under /{mm}-{dd}-{yy}/{pullZoneId}.log";
            var builder = new global::LoggingApiClient.WithMmWithDdWithYy.WithPullZoneIdLog.WithPullZoneIdLogRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WithMmWithDdWithYyRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/{mm}-{dd}-{yy}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::LoggingApiClient.WithMmWithDdWithYy.WithMmWithDdWithYyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithMmWithDdWithYyRequestBuilder(string rawUrl) : base("{+baseurl}/{mm}-{dd}-{yy}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
