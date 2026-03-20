#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Lists all agents associated with your account.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.GetAgentsResponse> AgentsListAsync(
            global::Cartesia.AgentsListCartesiaVersion cartesiaVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}