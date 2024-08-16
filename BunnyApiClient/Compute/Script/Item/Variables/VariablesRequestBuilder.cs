// <auto-generated/>
using BunnyApiClient.Compute.Script.Item.Variables.Add;
using BunnyApiClient.Compute.Script.Item.Variables.Item;
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
namespace BunnyApiClient.Compute.Script.Item.Variables
{
    /// <summary>
    /// Builds and executes requests for operations under \compute\script\{id}\variables
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class VariablesRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The add property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAddNavCommand()
        {
            var command = new Command("add");
            command.Description = "The add property";
            var builder = new global::BunnyApiClient.Compute.Script.Item.Variables.Add.AddRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Gets an item from the BunnyApiClient.compute.script.item.variables.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var builder = new global::BunnyApiClient.Compute.Script.Item.Variables.Item.WithVariableItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            executables.Add(builder.BuildPostCommand());
            return new(executables, new(0));
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.Item.Variables.VariablesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public VariablesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/compute/script/{id}/variables", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::BunnyApiClient.Compute.Script.Item.Variables.VariablesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VariablesRequestBuilder(string rawUrl) : base("{+baseurl}/compute/script/{id}/variables", rawUrl)
        {
        }
    }
}
