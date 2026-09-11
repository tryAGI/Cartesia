
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    public sealed partial class CartesiaSpeechToTextTurnsRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendSTTTurnsCloseCommandAsync(
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsCloseCommand message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsCloseCommand), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}