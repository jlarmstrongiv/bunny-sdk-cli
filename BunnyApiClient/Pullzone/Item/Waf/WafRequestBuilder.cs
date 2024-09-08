// <auto-generated/>
#pragma warning disable CS0618
using BunnyApiClient.Pullzone.Item.Waf.Statistics;
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
namespace BunnyApiClient.Pullzone.Item.Waf
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\waf
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WafRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The statistics property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildStatisticsNavCommand()
        {
            var command = new Command("statistics");
            command.Description = "The statistics property";
            var builder = new global::BunnyApiClient.Pullzone.Item.Waf.Statistics.StatisticsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Waf.WafRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WafRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/{%2Did}/waf", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Pullzone.Item.Waf.WafRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WafRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/{%2Did}/waf", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
