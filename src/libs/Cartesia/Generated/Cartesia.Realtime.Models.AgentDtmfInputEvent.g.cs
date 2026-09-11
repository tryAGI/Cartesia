
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// Sends a DTMF (dual-tone multi-frequency) digit to the agent.
    /// </summary>
    public sealed partial class AgentDtmfInputEvent
    {
        /// <summary>
        /// Event type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.Realtime.JsonConverters.AgentDtmfInputEventTypeJsonConverter))]
        public global::Cartesia.Realtime.AgentDtmfInputEventType Type { get; set; }

        /// <summary>
        /// A single DTMF digit, one of `0`-`9`, `*`, or `#`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDtmfInputEvent" /> class.
        /// </summary>
        /// <param name="digit">
        /// A single DTMF digit, one of `0`-`9`, `*`, or `#`.
        /// </param>
        /// <param name="type">
        /// Event type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDtmfInputEvent(
            string digit,
            global::Cartesia.Realtime.AgentDtmfInputEventType type)
        {
            this.Type = type;
            this.Digit = digit ?? throw new global::System.ArgumentNullException(nameof(digit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDtmfInputEvent" /> class.
        /// </summary>
        public AgentDtmfInputEvent()
        {
        }

    }
}