
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionReadyEventAudio
    {
        /// <summary>
        /// The accepted input format, echoed from `session_create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_format")]
        public string? InputFormat { get; set; }

        /// <summary>
        /// The resolved output delivery mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_delivery")]
        public string? OutputDelivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionReadyEventAudio" /> class.
        /// </summary>
        /// <param name="inputFormat">
        /// The accepted input format, echoed from `session_create`.
        /// </param>
        /// <param name="outputDelivery">
        /// The resolved output delivery mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionReadyEventAudio(
            string? inputFormat,
            string? outputDelivery)
        {
            this.InputFormat = inputFormat;
            this.OutputDelivery = outputDelivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionReadyEventAudio" /> class.
        /// </summary>
        public AgentSessionReadyEventAudio()
        {
        }

    }
}