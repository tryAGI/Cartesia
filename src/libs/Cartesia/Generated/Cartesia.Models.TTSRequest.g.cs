
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSRequest
    {
        /// <summary>
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.TTSRequestVoiceSpecifier Voice { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SupportedLanguageJsonConverter))]
        public global::Cartesia.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public global::Cartesia.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OutputFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cartesia.OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Whether to save the generated audio file. When true, the response will include a `Cartesia-File-ID` header.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dict_id")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// Use `generation_config.speed` for sonic-3.<br/>
        /// Speed setting for the model. Defaults to `normal`.<br/>
        /// This feature is experimental and may not work for all voices.<br/>
        /// Influences the speed of the generated speech. Faster speeds may reduce hallucination rate.<br/>
        /// Default Value: normal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.ModelSpeedJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Cartesia.ModelSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="save">
        /// Whether to save the generated audio file. When true, the response will include a `Cartesia-File-ID` header.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSRequest(
            string modelId,
            string transcript,
            global::Cartesia.TTSRequestVoiceSpecifier voice,
            global::Cartesia.OutputFormat outputFormat,
            global::Cartesia.SupportedLanguage? language,
            global::Cartesia.GenerationConfig? generationConfig,
            bool? save,
            string? pronunciationDictId)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.OutputFormat = outputFormat;
            this.Language = language;
            this.GenerationConfig = generationConfig;
            this.Save = save;
            this.PronunciationDictId = pronunciationDictId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequest" /> class.
        /// </summary>
        public TTSRequest()
        {
        }
    }
}