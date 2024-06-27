// <auto-generated/>
using BunnyApiClient.Pullzone.Item.Optimizer.Statistics;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace BunnyApiClient.Pullzone.Item.Optimizer
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\optimizer
    /// </summary>
    public class OptimizerRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The statistics property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildStatisticsNavCommand()
        {
            var command = new Command("statistics");
            command.Description = "The statistics property";
            var builder = new global::BunnyApiClient.Pullzone.Item.Optimizer.Statistics.StatisticsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Optimizer.OptimizerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public OptimizerRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/{%2Did}/optimizer", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Optimizer.OptimizerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OptimizerRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/{%2Did}/optimizer", rawUrl)
        {
        }
    }
}
