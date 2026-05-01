#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Deployment<br/>
        /// Get a deployment by its ID.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Deployment> AgentsGetDeploymentAsync(
            global::Cartesia.AgentsGetDeploymentCartesiaVersion cartesiaVersion,
            string deploymentId,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}