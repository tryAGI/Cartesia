#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Clone Voice<br/>
        /// Clone a high similarity voice from an audio clip. Clones are more similar to the source clip, but may reproduce background noise. For these, use an audio clip about 5 seconds long.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesCloneAsync(
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion,

            global::Cartesia.VoicesCloneRequest request,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Voice<br/>
        /// Clone a high similarity voice from an audio clip. Clones are more similar to the source clip, but may reproduce background noise. For these, use an audio clip about 5 seconds long.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="description">
        /// A description for the voice.
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="baseVoiceId">
        /// The ID of the voice.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesCloneAsync(
            global::Cartesia.VoicesCloneCartesiaVersion cartesiaVersion,
            byte[]? clip = default,
            string? clipname = default,
            string? name = default,
            string? description = default,
            global::Cartesia.SupportedLanguage? language = default,
            string? baseVoiceId = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}