// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using StreamApiClient.Library.Item.Videos.Item.Captions.Item;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System;
namespace StreamApiClient.Library.Item.Videos.Item.Captions
{
    /// <summary>
    /// Builds and executes requests for operations under \library\{libraryId}\videos\{videoId}\captions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CaptionsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets an item from the StreamApiClient.library.item.videos.item.captions.item collection
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var builder = new global::StreamApiClient.Library.Item.Videos.Item.Captions.Item.WithSrclangPathParameterItemRequestBuilder(PathParameters);
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildPostCommand());
            return new(executables, new(0));
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CaptionsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/library/{libraryId}/videos/{videoId}/captions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::StreamApiClient.Library.Item.Videos.Item.Captions.CaptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CaptionsRequestBuilder(string rawUrl) : base("{+baseurl}/library/{libraryId}/videos/{videoId}/captions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
