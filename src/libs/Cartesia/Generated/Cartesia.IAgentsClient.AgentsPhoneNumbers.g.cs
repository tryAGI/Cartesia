#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Phone Numbers<br/>
        /// List the phone numbers associated with an agent. Currently, you can only have one phone number per agent and these are provisioned by Cartesia.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>> AgentsPhoneNumbersAsync(
            string agentId,
            global::Cartesia.AgentsPhoneNumbersCartesiaVersion cartesiaVersion = global::Cartesia.AgentsPhoneNumbersCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Phone Numbers<br/>
        /// List the phone numbers associated with an agent. Currently, you can only have one phone number per agent and these are provisioned by Cartesia.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Default Value: 2026-08-14<br/>
        /// Example: 2026-08-14
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>>> AgentsPhoneNumbersAsResponseAsync(
            string agentId,
            global::Cartesia.AgentsPhoneNumbersCartesiaVersion cartesiaVersion = global::Cartesia.AgentsPhoneNumbersCartesiaVersion.x20260814,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}