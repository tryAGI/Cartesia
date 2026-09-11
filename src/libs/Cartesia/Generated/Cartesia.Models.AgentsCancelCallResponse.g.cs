
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsCancelCallResponse
    {
        /// <summary>
        /// Always `true` when the cancel is confirmed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Cancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCancelCallResponse" /> class.
        /// </summary>
        /// <param name="cancelled">
        /// Always `true` when the cancel is confirmed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCancelCallResponse(
            bool cancelled)
        {
            this.Cancelled = cancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCancelCallResponse" /> class.
        /// </summary>
        public AgentsCancelCallResponse()
        {
        }

    }
}