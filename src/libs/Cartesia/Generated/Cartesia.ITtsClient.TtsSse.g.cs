#nullable enable

namespace Cartesia
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Text-to-Speech (SSE)<br/>
        /// Stream audio with extra metadata from a complete transcript
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.TTSSSEEvent> TtsSseAsync(

            global::Cartesia.TTSSSERequest request,
            global::Cartesia.TtsSseCartesiaVersion cartesiaVersion = global::Cartesia.TtsSseCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text-to-Speech (SSE)<br/>
        /// Stream audio with extra metadata from a complete transcript
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.TTSSSEEvent> TtsSseAsync(
            global::Cartesia.TTSRequestVoiceSpecifier voice,
            global::Cartesia.SSEOutputFormat outputFormat,
            global::Cartesia.TtsSseCartesiaVersion cartesiaVersion = global::Cartesia.TtsSseCartesiaVersion.x20260814,
            global::Cartesia.TTSModelID modelId = global::Cartesia.TTSModelID.Sonic36,
            string transcript = "Hi there, it's awesome to meet you.",
            string? language = default,
            string? locale = default,
            string? accent = default,
            string? normalization = default,
            bool? addTimestamps = default,
            bool? addPhonemeTimestamps = default,
            bool? useNormalizedTimestamps = default,
            string? pronunciationDictId = default,
            global::Cartesia.GenerationConfig? generationConfig = default,
            string? contextId = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}