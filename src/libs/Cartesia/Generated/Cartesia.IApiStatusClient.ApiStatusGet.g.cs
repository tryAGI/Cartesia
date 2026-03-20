#nullable enable

namespace Cartesia
{
    public partial interface IApiStatusClient
    {
        /// <summary>
        /// API Status and Version
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.APIInfo> ApiStatusGetAsync(
            global::Cartesia.ApiStatusGetCartesiaVersion cartesiaVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}