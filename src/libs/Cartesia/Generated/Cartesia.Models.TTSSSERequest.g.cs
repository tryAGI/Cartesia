
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TTSSSERequest
    {
        /// <summary>
        /// The ID of the model to use for the generation.<br/>
        /// See [Models](/build-with-cartesia/tts-models/latest) all options.<br/>
        /// Default Value: sonic-3.6<br/>
        /// Example: sonic-3.6
        /// </summary>
        /// <default>global::Cartesia.TTSModelID.Sonic36</default>
        /// <example>sonic-3.6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSModelIDJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.TTSModelID ModelId { get; set; } = global::Cartesia.TTSModelID.Sonic36;

        /// <summary>
        /// Default Value: Hi there, it's awesome to meet you.
        /// </summary>
        /// <default>"Hi there, it's awesome to meet you."</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; } = "Hi there, it's awesome to meet you.";

        /// <summary>
        /// The voice to use for generation. Pass either a voice ID string or an object with a required `id` (additional object fields may be added in future API versions). Find a voice in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list). Embeddings are not accepted in this API version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.TTSRequestVoiceSpecifierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.TTSRequestVoiceSpecifier Voice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.SSEOutputFormat OutputFormat { get; set; }

        /// <summary>
        /// The transcript's language or locale (for example `en` or `en-GB`). `language` and `locale` accept the same values. Set one or the other, never both; setting both returns a 400 error. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The transcript's language or locale (for example `en` or `en-GB`). `locale` and `language` accept the same values. Set one or the other, never both; setting both returns a 400 error. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Usually unnecessary: Cartesia picks the closest accent the voice supports for the requested `language` or `locale`. Set it only to make a [multilingual voice](/build-with-cartesia/capability-guides/multilingual-voices) sound accented (e.g. speak English with a French accent). Must come from the voice's [Get Voice `accents` field](/api-reference/voices/get#response-accents). Learn more [here](/build-with-cartesia/capability-guides/multilingual-voices#using-a-multilingual-voice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Text normalization. `auto` (default) runs the locale-aware normalizer, `off` skips it, or pass a language or locale code (for example `en` or `en-IN`) to pin the normalizer independently of the generation language. See [Text Normalization](/build-with-cartesia/capability-guides/text-normalization).<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalization")]
        public string? Normalization { get; set; }

        /// <summary>
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_timestamps")]
        public bool? AddTimestamps { get; set; }

        /// <summary>
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_phoneme_timestamps")]
        public bool? AddPhonemeTimestamps { get; set; }

        /// <summary>
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_normalized_timestamps")]
        public bool? UseNormalizedTimestamps { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict_id")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// Configure the various attributes of the generated speech. Available on `sonic-3` and newer models; not available on earlier models.<br/>
        /// See [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) for a guide on this option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public global::Cartesia.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSERequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for the generation.<br/>
        /// See [Models](/build-with-cartesia/tts-models/latest) all options.<br/>
        /// Default Value: sonic-3.6<br/>
        /// Example: sonic-3.6
        /// </param>
        /// <param name="transcript">
        /// Default Value: Hi there, it's awesome to meet you.
        /// </param>
        /// <param name="voice">
        /// The voice to use for generation. Pass either a voice ID string or an object with a required `id` (additional object fields may be added in future API versions). Find a voice in the [Voice Library](https://play.cartesia.ai/voices) or via [List Voices](/api-reference/voices/list). Embeddings are not accepted in this API version.
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="language">
        /// The transcript's language or locale (for example `en` or `en-GB`). `language` and `locale` accept the same values. Set one or the other, never both; setting both returns a 400 error. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </param>
        /// <param name="locale">
        /// The transcript's language or locale (for example `en` or `en-GB`). `locale` and `language` accept the same values. Set one or the other, never both; setting both returns a 400 error. See [supported codes](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
        /// </param>
        /// <param name="accent">
        /// Usually unnecessary: Cartesia picks the closest accent the voice supports for the requested `language` or `locale`. Set it only to make a [multilingual voice](/build-with-cartesia/capability-guides/multilingual-voices) sound accented (e.g. speak English with a French accent). Must come from the voice's [Get Voice `accents` field](/api-reference/voices/get#response-accents). Learn more [here](/build-with-cartesia/capability-guides/multilingual-voices#using-a-multilingual-voice).
        /// </param>
        /// <param name="normalization">
        /// Text normalization. `auto` (default) runs the locale-aware normalizer, `off` skips it, or pass a language or locale code (for example `en` or `en-IN`) to pin the normalizer independently of the generation language. See [Text Normalization](/build-with-cartesia/capability-guides/text-normalization).<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="addTimestamps">
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="addPhonemeTimestamps">
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useNormalizedTimestamps">
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. Available on `sonic-3` and newer models; not available on earlier models.<br/>
        /// See [Volume, Speed, and Emotion](/build-with-cartesia/capability-guides/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="contextId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSSSERequest(
            global::Cartesia.TTSModelID modelId,
            string transcript,
            global::Cartesia.TTSRequestVoiceSpecifier voice,
            global::Cartesia.SSEOutputFormat outputFormat,
            string? language,
            string? locale,
            string? accent,
            string? normalization,
            bool? addTimestamps,
            bool? addPhonemeTimestamps,
            bool? useNormalizedTimestamps,
            string? pronunciationDictId,
            global::Cartesia.GenerationConfig? generationConfig,
            string? contextId)
        {
            this.ModelId = modelId;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Voice = voice;
            this.OutputFormat = outputFormat ?? throw new global::System.ArgumentNullException(nameof(outputFormat));
            this.Language = language;
            this.Locale = locale;
            this.Accent = accent;
            this.Normalization = normalization;
            this.AddTimestamps = addTimestamps;
            this.AddPhonemeTimestamps = addPhonemeTimestamps;
            this.UseNormalizedTimestamps = useNormalizedTimestamps;
            this.PronunciationDictId = pronunciationDictId;
            this.GenerationConfig = generationConfig;
            this.ContextId = contextId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSSSERequest" /> class.
        /// </summary>
        public TTSSSERequest()
        {
        }

    }
}