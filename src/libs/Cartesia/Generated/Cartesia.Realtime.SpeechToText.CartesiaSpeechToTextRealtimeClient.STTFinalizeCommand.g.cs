
#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    public sealed partial class CartesiaSpeechToTextRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendSTTFinalizeCommandAsync(
            global::Cartesia.Realtime.SpeechToText.STTFinalizeCommand message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await SendAsync(message.ToValueString(), cancellationToken).ConfigureAwait(false);
        }
    }
}