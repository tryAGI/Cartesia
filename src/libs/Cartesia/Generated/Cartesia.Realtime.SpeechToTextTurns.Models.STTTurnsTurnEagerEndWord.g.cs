
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class STTTurnsTurnEagerEndWord
    {
        /// <summary>
        /// The word with any punctuation attached. `ink-whisper` words can start with a space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Start time in seconds, counted from the start of the audio sent on the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End time in seconds, counted from the start of the audio sent on the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnEagerEndWord" /> class.
        /// </summary>
        /// <param name="word">
        /// The word with any punctuation attached. `ink-whisper` words can start with a space.
        /// </param>
        /// <param name="start">
        /// Start time in seconds, counted from the start of the audio sent on the connection
        /// </param>
        /// <param name="end">
        /// End time in seconds, counted from the start of the audio sent on the connection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTTurnsTurnEagerEndWord(
            string word,
            double start,
            double end)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTTurnsTurnEagerEndWord" /> class.
        /// </summary>
        public STTTurnsTurnEagerEndWord()
        {
        }

    }
}