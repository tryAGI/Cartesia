
#nullable enable

namespace Cartesia.Realtime
{
    public sealed partial class CartesiaManagedAgentRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendAgentAudioInputEventAsync(
            global::Cartesia.Realtime.AgentAudioInputEvent message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Cartesia.Realtime.AgentAudioInputEvent), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded audio in the format declared in `session_create.audio.input_format`.
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="type">Event type identifier.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendAgentAudioInputEventAsync(
            global::System.ReadOnlyMemory<byte> audio,
            global::Cartesia.Realtime.AgentAudioInputEventType type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendAgentAudioInputEventAsync(
                new global::Cartesia.Realtime.AgentAudioInputEvent
                {
                Audio = global::System.Convert.ToBase64String(audio.Span),
                Type = type,
                },
                cancellationToken);
        }
    }
}