
#nullable enable

namespace Cartesia.Realtime
{
    public sealed partial class CartesiaManagedAgentRealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Cartesia.Realtime.ServerEvent> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            continue;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (global::System.OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: "Closing",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (!__receivedTextMessage)
                {
                    continue;
                }

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
                    global::Cartesia.Realtime.ServerEvent @event;
                    try
                    {
                        @event = (global::Cartesia.Realtime.ServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::Cartesia.Realtime.ServerEvent), JsonSerializerContext)!;
                    }
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {
                            throw;
                        }

                        continue;
                    }

                    DispatchReceivedMessage(@event, json);
                    yield return @event;
            }
        }


        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {
            try
            {
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }
            catch (global::System.Text.Json.JsonException)
            {
                return null;
            }
        }

        private void DispatchUnknownMessage(
            string rawText)
        {
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }

        private void DispatchReceivedMessage(
            global::Cartesia.Realtime.ServerEvent @event,
            string rawText)
        {
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.ServerEvent>(
                    @event,
                    rawText,
                    json));

            if (@event.SessionReady is { } __AgentSessionReadyEventReceived)
            {
                AgentSessionReadyEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentSessionReadyEvent>(
                        __AgentSessionReadyEventReceived,
                        rawText,
                        json));
            }
            if (@event.AudioOutput is { } __AgentAudioOutputEventReceived)
            {
                AgentAudioOutputEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentAudioOutputEvent>(
                        __AgentAudioOutputEventReceived,
                        rawText,
                        json));
            }
            if (@event.AudioOutputClear is { } __AgentAudioOutputClearEventReceived)
            {
                AgentAudioOutputClearEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentAudioOutputClearEvent>(
                        __AgentAudioOutputClearEventReceived,
                        rawText,
                        json));
            }
            if (@event.DtmfOutput is { } __AgentDtmfOutputEventReceived)
            {
                AgentDtmfOutputEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentDtmfOutputEvent>(
                        __AgentDtmfOutputEventReceived,
                        rawText,
                        json));
            }
            if (@event.ClientToolCall is { } __AgentClientToolCallEventReceived)
            {
                AgentClientToolCallEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentClientToolCallEvent>(
                        __AgentClientToolCallEventReceived,
                        rawText,
                        json));
            }
            if (@event.TurnStarted is { } __AgentTurnStartedEventReceived)
            {
                AgentTurnStartedEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentTurnStartedEvent>(
                        __AgentTurnStartedEventReceived,
                        rawText,
                        json));
            }
            if (@event.TurnOutputTextDelta is { } __AgentTurnOutputTextDeltaEventReceived)
            {
                AgentTurnOutputTextDeltaEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent>(
                        __AgentTurnOutputTextDeltaEventReceived,
                        rawText,
                        json));
            }
            if (@event.TurnEnded is { } __AgentTurnEndedEventReceived)
            {
                AgentTurnEndedEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentTurnEndedEvent>(
                        __AgentTurnEndedEventReceived,
                        rawText,
                        json));
            }
            if (@event.Error is { } __AgentErrorEventReceived)
            {
                AgentErrorEventReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.AgentErrorEvent>(
                        __AgentErrorEventReceived,
                        rawText,
                        json));
            }
        }
    }
}