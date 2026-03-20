#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Deployment<br/>
        /// Get a deployment by its ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="deploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Deployment> AgentsGetDeploymentAsync(
            global::Cartesia.AgentsGetDeploymentCartesiaVersion cartesiaVersion,
            string deploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}