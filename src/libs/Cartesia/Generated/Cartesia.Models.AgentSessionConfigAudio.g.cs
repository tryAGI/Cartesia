
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionConfigAudio
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Cartesia.AgentSessionConfigAudioOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfigAudio" /> class.
        /// </summary>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionConfigAudio(
            global::Cartesia.AgentSessionConfigAudioOutput? output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConfigAudio" /> class.
        /// </summary>
        public AgentSessionConfigAudio()
        {
        }

    }
}