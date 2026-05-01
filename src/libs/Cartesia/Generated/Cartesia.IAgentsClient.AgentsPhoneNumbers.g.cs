#nullable enable

namespace Cartesia
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Phone Numbers<br/>
        /// List the phone numbers associated with an agent. Currently, you can only have one phone number per agent and these are provisioned by Cartesia.
        /// </summary>
        /// <param name="cartesiaVersion"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Cartesia.PhoneNumber>> AgentsPhoneNumbersAsync(
            global::Cartesia.AgentsPhoneNumbersCartesiaVersion cartesiaVersion,
            string agentId,
            global::Cartesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}