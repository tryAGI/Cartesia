
#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfillBytesRequest
    {
        /// <summary>
        /// Audio clip that comes before the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_audio")]
        public byte[]? LeftAudio { get; set; }

        /// <summary>
        /// Audio clip that comes before the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_audioname")]
        public string? LeftAudioname { get; set; }

        /// <summary>
        /// Audio clip that comes after the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_audio")]
        public byte[]? RightAudio { get; set; }

        /// <summary>
        /// Audio clip that comes after the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_audioname")]
        public string? RightAudioname { get; set; }

        /// <summary>
        /// The ID of the model to use for generating audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.InfillBytesRequestModelIdJsonConverter))]
        public global::Cartesia.InfillBytesRequestModelId? ModelId { get; set; }

        /// <summary>
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.SupportedLanguageJsonConverter))]
        public global::Cartesia.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// The infill text to generate.<br/>
        /// For best results, use longer transcripts to give the model more flexibility to adapt to the rest of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The ID of the voice to use for generating audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[container]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.OutputFormatContainerJsonConverter))]
        public global::Cartesia.OutputFormatContainer? OutputFormatContainer { get; set; }

        /// <summary>
        /// The sample rate of the output audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[sample_rate]")]
        public int? OutputFormatSampleRate { get; set; }

        /// <summary>
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[encoding]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cartesia.JsonConverters.RawEncodingJsonConverter))]
        public global::Cartesia.RawEncoding? OutputFormatEncoding { get; set; }

        /// <summary>
        /// Required for `mp3` containers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[bit_rate]")]
        public int? OutputFormatBitRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfillBytesRequest" /> class.
        /// </summary>
        /// <param name="leftAudio">
        /// Audio clip that comes before the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="leftAudioname">
        /// Audio clip that comes before the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="rightAudio">
        /// Audio clip that comes after the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="rightAudioname">
        /// Audio clip that comes after the infill transcript:<br/>
        /// `left_audio` -&gt; `transcript` -&gt; `right_audio`<br/>
        /// For best results, target natural pauses in the audio and clip tightly.<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// Supported audio formats: `flac`, `mp3`, `mpeg`, `mpga`, `oga`, `ogg`, `wav`, `webm`
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for generating audio
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. This may depend on the model you're using. See [Models](/build-with-cartesia/tts-models/latest) for details.
        /// </param>
        /// <param name="transcript">
        /// The infill text to generate.<br/>
        /// For best results, use longer transcripts to give the model more flexibility to adapt to the rest of the audio.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to use for generating audio
        /// </param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate">
        /// The sample rate of the output audio
        /// </param>
        /// <param name="outputFormatEncoding">
        /// The encoding format for output audio. See [TTS Output Audio Format](/build-with-cartesia/capability-guides/tts-output-audio-format) if you're unsure what to use.
        /// </param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfillBytesRequest(
            byte[]? leftAudio,
            string? leftAudioname,
            byte[]? rightAudio,
            string? rightAudioname,
            global::Cartesia.InfillBytesRequestModelId? modelId,
            global::Cartesia.SupportedLanguage? language,
            string? transcript,
            string? voiceId,
            global::Cartesia.OutputFormatContainer? outputFormatContainer,
            int? outputFormatSampleRate,
            global::Cartesia.RawEncoding? outputFormatEncoding,
            int? outputFormatBitRate)
        {
            this.LeftAudio = leftAudio;
            this.LeftAudioname = leftAudioname;
            this.RightAudio = rightAudio;
            this.RightAudioname = rightAudioname;
            this.ModelId = modelId;
            this.Language = language;
            this.Transcript = transcript;
            this.VoiceId = voiceId;
            this.OutputFormatContainer = outputFormatContainer;
            this.OutputFormatSampleRate = outputFormatSampleRate;
            this.OutputFormatEncoding = outputFormatEncoding;
            this.OutputFormatBitRate = outputFormatBitRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfillBytesRequest" /> class.
        /// </summary>
        public InfillBytesRequest()
        {
        }

    }
}