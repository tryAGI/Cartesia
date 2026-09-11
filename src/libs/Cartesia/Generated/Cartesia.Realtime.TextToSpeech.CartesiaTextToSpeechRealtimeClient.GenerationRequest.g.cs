
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    public sealed partial class CartesiaTextToSpeechRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendGenerationRequestAsync(
            global::Cartesia.Realtime.TextToSpeech.GenerationRequest message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Cartesia.Realtime.TextToSpeech.GenerationRequest), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}