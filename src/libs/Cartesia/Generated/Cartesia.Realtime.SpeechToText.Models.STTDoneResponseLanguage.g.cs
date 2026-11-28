
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class STTDoneResponseLanguage
    {
        /// <summary>
        /// Language code. See [Languages](/use-the-api/stt/languages).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// How confident the model is that this language was spoken, from 0 (not confident) to 1 (very confident).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTDoneResponseLanguage" /> class.
        /// </summary>
        /// <param name="language">
        /// Language code. See [Languages](/use-the-api/stt/languages).
        /// </param>
        /// <param name="confidence">
        /// How confident the model is that this language was spoken, from 0 (not confident) to 1 (very confident).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTDoneResponseLanguage(
            string language,
            double confidence)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTDoneResponseLanguage" /> class.
        /// </summary>
        public STTDoneResponseLanguage()
        {
        }

    }
}