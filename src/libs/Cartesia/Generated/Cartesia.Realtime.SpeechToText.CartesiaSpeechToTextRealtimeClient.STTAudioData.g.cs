
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
        public async global::System.Threading.Tasks.Task SendSTTAudioDataAsync(
            byte[] message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            await SendAsync(
                new global::System.ArraySegment<byte>(message),
                global::System.Net.WebSockets.WebSocketMessageType.Binary,
                endOfMessage: true,
                cancellationToken).ConfigureAwait(false);
        }
    }
}