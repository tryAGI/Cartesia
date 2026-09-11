#nullable enable

namespace Cartesia
{
    public partial interface IInfillClient
    {
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> InfillBytesAsStreamAsync(

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<byte[]>> InfillBytesAsResponseAsync(

            global::Cartesia.InfillBytesRequest request,
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::Cartesia.InfillBytesCartesiaVersion cartesiaVersion = global::Cartesia.InfillBytesCartesiaVersion.x20260814,
            byte[]? leftAudio = default,
            string? leftAudioname = default,
            byte[]? rightAudio = default,
            string? rightAudioname = default,
            global::Cartesia.InfillBytesRequestModelId? modelId = default,
            global::Cartesia.SupportedLanguage? language = default,
            string? transcript = default,
            string? voiceId = default,
            global::Cartesia.OutputFormatContainer? outputFormatContainer = default,
            int? outputFormatSampleRate = default,
            global::Cartesia.RawEncoding? outputFormatEncoding = default,
            int? outputFormatBitRate = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}