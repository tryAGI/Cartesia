#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Metric<br/>
        /// Get a metric by its ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="metricId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.Metric> AgentsGetMetricAsync(
            global::Cartesia.AgentsGetMetricCartesiaVersion cartesiaVersion,
            string metricId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}