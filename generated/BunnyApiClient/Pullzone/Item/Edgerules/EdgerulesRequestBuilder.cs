// <auto-generated/>
using BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate;
using BunnyApiClient.Pullzone.Item.Edgerules.Item;
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
namespace BunnyApiClient.Pullzone.Item.Edgerules
{
    /// <summary>
    /// Builds and executes requests for operations under \pullzone\{-id}\edgerules
    /// </summary>
    public class EdgerulesRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The addOrUpdate property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAddOrUpdateNavCommand()
        {
            var command = new Command("add-or-update");
            command.Description = "The addOrUpdate property";
            var builder = new global::BunnyApiClient.Pullzone.Item.Edgerules.AddOrUpdate.AddOrUpdateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Gets an item from the BunnyApiClient.pullzone.item.edgerules.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new global::BunnyApiClient.Pullzone.Item.Edgerules.Item.WithEdgeRuleItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildDeleteCommand());
            commands.Add(builder.BuildSetEdgeRuleEnabledNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Edgerules.EdgerulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EdgerulesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/pullzone/{%2Did}/edgerules", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BunnyApiClient.Pullzone.Item.Edgerules.EdgerulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EdgerulesRequestBuilder(string rawUrl) : base("{+baseurl}/pullzone/{%2Did}/edgerules", rawUrl)
        {
        }
    }
}
