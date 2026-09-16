
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Arguments supplied by the model. For webhook tools, this excludes values filled from dynamic variables or constants.
    /// </summary>
    public sealed partial class ToolCallArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}