
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    /// Phoneme-level timing information
    /// </summary>
    public sealed partial class PhonemeTimestampsResponsePhonemeTimestamps
    {
        /// <summary>
        /// List of phonemes in order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phonemes")]
        public global::System.Collections.Generic.IList<string>? Phonemes { get; set; }

        /// <summary>
        /// Start times in seconds for each phoneme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.Collections.Generic.IList<double>? Start { get; set; }

        /// <summary>
        /// End times in seconds for each phoneme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.Collections.Generic.IList<double>? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemeTimestampsResponsePhonemeTimestamps" /> class.
        /// </summary>
        /// <param name="phonemes">
        /// List of phonemes in order
        /// </param>
        /// <param name="start">
        /// Start times in seconds for each phoneme
        /// </param>
        /// <param name="end">
        /// End times in seconds for each phoneme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhonemeTimestampsResponsePhonemeTimestamps(
            global::System.Collections.Generic.IList<string>? phonemes,
            global::System.Collections.Generic.IList<double>? start,
            global::System.Collections.Generic.IList<double>? end)
        {
            this.Phonemes = phonemes;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemeTimestampsResponsePhonemeTimestamps" /> class.
        /// </summary>
        public PhonemeTimestampsResponsePhonemeTimestamps()
        {
        }

    }
}