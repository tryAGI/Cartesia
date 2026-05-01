#nullable enable

namespace Cartesia
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// Retrieve a specific fine-tune by ID
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.FineTune> FineTunesGetAsync(
            global::Cartesia.FineTunesGetCartesiaVersion cartesiaVersion,
            string id,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}