
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateManagedAgentV1RequestConfigAudioInput
    {
        /// <summary>
        /// Words or phrases that the speech recognizer should prioritize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Noise suppression applied to incoming audio. Use `off` to disable it, `auto` for the default level, or `max` for stronger suppression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_suppression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppressionJsonConverter))]
        public global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? NoiseSuppression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigAudioInput" /> class.
        /// </summary>
        /// <param name="keyterms">
        /// Words or phrases that the speech recognizer should prioritize.
        /// </param>
        /// <param name="noiseSuppression">
        /// Noise suppression applied to incoming audio. Use `off` to disable it, `auto` for the default level, or `max` for stronger suppression.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateManagedAgentV1RequestConfigAudioInput(
            global::System.Collections.Generic.IList<string>? keyterms,
            global::Cartesia.UpdateManagedAgentV1RequestConfigAudioInputNoiseSuppression? noiseSuppression)
        {
            this.Keyterms = keyterms;
            this.NoiseSuppression = noiseSuppression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateManagedAgentV1RequestConfigAudioInput" /> class.
        /// </summary>
        public UpdateManagedAgentV1RequestConfigAudioInput()
        {
        }

    }
}