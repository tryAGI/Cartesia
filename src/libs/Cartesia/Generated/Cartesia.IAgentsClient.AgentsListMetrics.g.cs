#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Metrics<br/>
        /// List of all LLM-as-a-Judge metrics owned by your account.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="startingAfter"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.ListMetricsResponse> AgentsListMetricsAsync(
            global::Cartesia.AgentsListMetricsCartesiaVersion cartesiaVersion,
            string? startingAfter = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}