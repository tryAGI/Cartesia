#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Voice> VoicesGetAsync(
            global::Cartesia.VoicesGetCartesiaVersion cartesiaVersion,
            string id,
            global::System.Collections.Generic.IList<global::Cartesia.VoiceExpandOptions>? expand = default,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}