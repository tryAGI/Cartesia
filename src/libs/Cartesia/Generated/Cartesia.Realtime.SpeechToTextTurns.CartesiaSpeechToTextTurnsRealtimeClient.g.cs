
#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    /// Realtime speech transcription with built-in turn detection<br/>
    /// &lt;Note&gt;<br/>
    /// `ink-2` supports English only. For English, French, Hindi, Japanese, and Spanish, use `ink-preview`;<br/>
    /// it detects the language automatically.<br/>
    /// &lt;/Note&gt;
    /// </summary>
    public sealed partial class CartesiaSpeechToTextTurnsRealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.cartesia.ai/stt/turns/websocket";

        private global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;
        private global::System.Uri? _lastConnectUri;
        private global::System.Collections.Generic.Dictionary<string, string>? _lastAdditionalHeaders;
        private global::System.Collections.Generic.List<string>? _lastAdditionalSubProtocols;
        private global::System.TimeSpan? _lastKeepAliveInterval;
        private global::System.TimeSpan? _lastConnectTimeout;


        /// <summary>
        /// Current WebSocket connection status.
        /// </summary>
        public enum AutoSDKWebSocketConnectionStatus
        {
            /// <summary>
            /// The client is not connected.
            /// </summary>
            Disconnected,

            /// <summary>
            /// The client is connecting.
            /// </summary>
            Connecting,

            /// <summary>
            /// The client is connected.
            /// </summary>
            Connected,

            /// <summary>
            /// The client observed a normal close.
            /// </summary>
            Closed,

            /// <summary>
            /// The client observed a connection error.
            /// </summary>
            Faulted,
        }

        /// <summary>
        /// Configures automatic reconnect attempts after receive-loop WebSocket failures.
        /// </summary>
        public sealed class AutoSDKWebSocketReconnectOptions
        {
            /// <summary>
            /// Enables reconnect attempts from the receive loop.
            /// </summary>
            public bool Enabled { get; set; }

            /// <summary>
            /// Maximum reconnect attempts per observed receive failure.
            /// </summary>
            public int MaxAttempts { get; set; } = 3;

            /// <summary>
            /// Delay before the first reconnect attempt.
            /// </summary>
            public global::System.TimeSpan InitialDelay { get; set; } = global::System.TimeSpan.FromSeconds(1);

            /// <summary>
            /// Maximum delay between reconnect attempts.
            /// </summary>
            public global::System.TimeSpan MaxDelay { get; set; } = global::System.TimeSpan.FromSeconds(30);

            /// <summary>
            /// Multiplier applied to the delay after each failed reconnect attempt.
            /// </summary>
            public double BackoffMultiplier { get; set; } = 2D;
        }

        /// <summary>
        /// Event data for closed WebSocket connections.
        /// </summary>
        public sealed class AutoSDKWebSocketClosedEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketClosedEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketClosedEventArgs(
                global::System.Net.WebSockets.WebSocketCloseStatus? closeStatus,
                string? closeStatusDescription)
            {
                CloseStatus = closeStatus;
                CloseStatusDescription = closeStatusDescription;
            }

            /// <summary>
            /// Gets the WebSocket close status.
            /// </summary>
            public global::System.Net.WebSockets.WebSocketCloseStatus? CloseStatus { get; }

            /// <summary>
            /// Gets the WebSocket close status description.
            /// </summary>
            public string? CloseStatusDescription { get; }
        }

        /// <summary>
        /// Event data for WebSocket exceptions.
        /// </summary>
        public sealed class AutoSDKWebSocketExceptionEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketExceptionEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketExceptionEventArgs(
                global::System.Exception exception)
            {
                Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            }

            /// <summary>
            /// Gets the observed exception.
            /// </summary>
            public global::System.Exception Exception { get; }
        }

        /// <summary>
        /// Event data for WebSocket reconnect attempts.
        /// </summary>
        public sealed class AutoSDKWebSocketReconnectEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketReconnectEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketReconnectEventArgs(
                int attempt,
                global::System.TimeSpan delay,
                global::System.Exception exception)
            {
                Attempt = attempt;
                Delay = delay;
                Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            }

            /// <summary>
            /// Gets the reconnect attempt number.
            /// </summary>
            public int Attempt { get; }

            /// <summary>
            /// Gets the delay before the reconnect attempt.
            /// </summary>
            public global::System.TimeSpan Delay { get; }

            /// <summary>
            /// Gets the exception that triggered reconnect.
            /// </summary>
            public global::System.Exception Exception { get; }
        }

        /// <summary>
        /// Event data for deserialized WebSocket messages.
        /// </summary>
        public sealed class AutoSDKWebSocketMessageEventArgs<TMessage> : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketMessageEventArgs{TMessage}"/> class.
            /// </summary>
            public AutoSDKWebSocketMessageEventArgs(
                TMessage message,
                string rawText,
                global::System.Text.Json.JsonElement? json)
            {
                Message = message;
                RawText = rawText ?? string.Empty;
                Json = json;
            }

            /// <summary>
            /// Gets the deserialized message.
            /// </summary>
            public TMessage Message { get; }

            /// <summary>
            /// Gets the raw text received from the WebSocket.
            /// </summary>
            public string RawText { get; }

            /// <summary>
            /// Gets the parsed JSON payload when available.
            /// </summary>
            public global::System.Text.Json.JsonElement? Json { get; }
        }

        /// <summary>
        /// Event data for messages that could not be deserialized into a known receive type.
        /// </summary>
        public sealed class AutoSDKWebSocketUnknownMessageEventArgs : global::System.EventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="AutoSDKWebSocketUnknownMessageEventArgs"/> class.
            /// </summary>
            public AutoSDKWebSocketUnknownMessageEventArgs(
                string rawText,
                global::System.Text.Json.JsonElement? json)
            {
                RawText = rawText ?? string.Empty;
                Json = json;
            }

            /// <summary>
            /// Gets the raw text received from the WebSocket.
            /// </summary>
            public string RawText { get; }

            /// <summary>
            /// Gets the parsed JSON payload when available.
            /// </summary>
            public global::System.Text.Json.JsonElement? Json { get; }
        }

        /// <summary>
        /// Gets the current WebSocket connection status.
        /// </summary>
        public AutoSDKWebSocketConnectionStatus Status { get; private set; } = AutoSDKWebSocketConnectionStatus.Disconnected;

        /// <summary>
        /// Gets reconnect options used by the receive loop.
        /// </summary>
        public AutoSDKWebSocketReconnectOptions ReconnectOptions { get; } = new AutoSDKWebSocketReconnectOptions();

        /// <summary>
        /// Raised after the WebSocket connection is opened.
        /// </summary>
        public event global::System.EventHandler? Connected;

        /// <summary>
        /// Raised after the WebSocket connection is closed.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketClosedEventArgs>? Closed;

        /// <summary>
        /// Raised after a WebSocket connection exception is observed.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketExceptionEventArgs>? ExceptionOccurred;

        /// <summary>
        /// Raised before a reconnect attempt starts.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketReconnectEventArgs>? Reconnecting;

        /// <summary>
        /// Raised when an inbound text message cannot be deserialized into a known receive event.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketUnknownMessageEventArgs>? UnknownMessage;

        /// <summary>
        /// Raised after a text message is deserialized into the receive event type.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.ServerEvent>>? MessageReceived;
        /// <summary>
        /// Raised after a STTTurnsConnected message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected>>? STTTurnsConnectedReceived;
        /// <summary>
        /// Raised after a STTTurnsTurnStart message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart>>? STTTurnsTurnStartReceived;
        /// <summary>
        /// Raised after a STTTurnsTurnUpdate message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate>>? STTTurnsTurnUpdateReceived;
        /// <summary>
        /// Raised after a STTTurnsTurnEagerEnd message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd>>? STTTurnsTurnEagerEndReceived;
        /// <summary>
        /// Raised after a STTTurnsTurnResume message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume>>? STTTurnsTurnResumeReceived;
        /// <summary>
        /// Raised after a STTTurnsTurnEnd message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd>>? STTTurnsTurnEndReceived;
        /// <summary>
        /// Raised after a STTErrorResponse message is deserialized.
        /// </summary>
        public event global::System.EventHandler<AutoSDKWebSocketMessageEventArgs<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse>>? STTErrorResponseReceived;

        /// <summary>
        ///
        /// </summary>

        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsSourceGenerationContext.Default;

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the CartesiaSpeechToTextTurnsRealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public CartesiaSpeechToTextTurnsRealtimeClient(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }


        private string? _storedAuthorizationHeaderName;
        private string? _storedAuthorizationHeaderScheme;
        private string? _storedAuthorizationApiKey;

        /// <summary>
        /// Authorize using API key in header.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _storedAuthorizationApiKey = apiKey;
            _storedAuthorizationHeaderName = "X-API-Key";
            _storedAuthorizationHeaderScheme = null;
        }

        /// <summary>
        /// Creates a new instance with API key header authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientWebSocket"></param>
        public CartesiaSpeechToTextTurnsRealtimeClient(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(_clientWebSocket);
        }

        /// <summary>
        /// Authorize using API key in query parameter.
        /// The key will be appended to the URL during ConnectAsync.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            // Query parameter auth is handled during ConnectAsync
            _queryApiKey = apiKey;
            _queryApiKeyName = "access_token";
        }

        private string? _queryApiKey;
        private string? _queryApiKeyName;





        private void ApplyStoredAuthorization(
            bool useSubprotocolAuth)
        {

            if (_storedAuthorizationApiKey is not null &&
                _storedAuthorizationHeaderName is not null)
            {
                var __authorizationValue = _storedAuthorizationHeaderScheme is not null
                    ? $"{_storedAuthorizationHeaderScheme} {_storedAuthorizationApiKey}"
                    : _storedAuthorizationApiKey;
                _clientWebSocket.Options.SetRequestHeader(_storedAuthorizationHeaderName, __authorizationValue);
            }
        }
        private void RememberConnectionOptions(
            global::System.Uri uri,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval,
            global::System.TimeSpan? connectTimeout)
        {
            _lastConnectUri = uri;
            _lastAdditionalHeaders = additionalHeaders is null
                ? null
                : new global::System.Collections.Generic.Dictionary<string, string>(
                    additionalHeaders,
                    global::System.StringComparer.OrdinalIgnoreCase);
            _lastAdditionalSubProtocols = additionalSubProtocols is null
                ? null
                : new global::System.Collections.Generic.List<string>(additionalSubProtocols);
            _lastKeepAliveInterval = keepAliveInterval;
            _lastConnectTimeout = connectTimeout;
        }

        private void ResetClientWebSocket()
        {
            _clientWebSocket.Dispose();
            _clientWebSocket = new global::System.Net.WebSockets.ClientWebSocket();
            Initialized(_clientWebSocket);
        }

        private void RaiseClosed(
            global::System.Net.WebSockets.WebSocketCloseStatus? closeStatus,
            string? closeStatusDescription)
        {
            Status = AutoSDKWebSocketConnectionStatus.Closed;
            Closed?.Invoke(
                this,
                new AutoSDKWebSocketClosedEventArgs(closeStatus, closeStatusDescription));
        }

        private void RaiseException(
            global::System.Exception exception)
        {
            Status = AutoSDKWebSocketConnectionStatus.Faulted;
            ExceptionOccurred?.Invoke(
                this,
                new AutoSDKWebSocketExceptionEventArgs(exception));
        }

        private global::System.TimeSpan GetReconnectDelay(
            int attempt)
        {
            var delay = ReconnectOptions.InitialDelay;
            if (delay < global::System.TimeSpan.Zero)
            {
                delay = global::System.TimeSpan.Zero;
            }

            var multiplier = ReconnectOptions.BackoffMultiplier;
            if (multiplier < 1D)
            {
                multiplier = 1D;
            }

            for (var index = 1; index < attempt; index++)
            {
                var nextMilliseconds = delay.TotalMilliseconds * multiplier;
                if (nextMilliseconds >= ReconnectOptions.MaxDelay.TotalMilliseconds)
                {
                    delay = ReconnectOptions.MaxDelay;
                    break;
                }

                delay = global::System.TimeSpan.FromMilliseconds(nextMilliseconds);
            }

            if (ReconnectOptions.MaxDelay >= global::System.TimeSpan.Zero &&
                delay > ReconnectOptions.MaxDelay)
            {
                delay = ReconnectOptions.MaxDelay;
            }

            return delay;
        }

        private async global::System.Threading.Tasks.Task<bool> TryReconnectAsync(
            global::System.Exception exception,
            global::System.Threading.CancellationToken cancellationToken)
        {
            if (!ReconnectOptions.Enabled ||
                _lastConnectUri is null ||
                cancellationToken.IsCancellationRequested)
            {
                return false;
            }

            var maxAttempts = ReconnectOptions.MaxAttempts < 1 ? 1 : ReconnectOptions.MaxAttempts;
            var lastException = exception;
            for (var attempt = 1; attempt <= maxAttempts; attempt++)
            {
                var delay = GetReconnectDelay(attempt);
                Reconnecting?.Invoke(
                    this,
                    new AutoSDKWebSocketReconnectEventArgs(attempt, delay, lastException));

                if (delay > global::System.TimeSpan.Zero)
                {
                    await global::System.Threading.Tasks.Task.Delay(delay, cancellationToken).ConfigureAwait(false);
                }

                try
                {
                    ResetClientWebSocket();
                    await ConnectAsync(
                        uri: _lastConnectUri,
                        additionalHeaders: _lastAdditionalHeaders,
                        additionalSubProtocols: _lastAdditionalSubProtocols,
                        keepAliveInterval: _lastKeepAliveInterval,
                        connectTimeout: _lastConnectTimeout,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    return true;
                }
                catch (global::System.Exception reconnectException) when (
                    reconnectException is global::System.Net.WebSockets.WebSocketException ||
                    reconnectException is global::System.Net.Http.HttpRequestException ||
                    reconnectException is global::System.OperationCanceledException)
                {
                    lastException = reconnectException;
                    RaiseException(reconnectException);
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        private void ApplyConnectionOptions(
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval)
        {
            if (keepAliveInterval is not null)
            {
                _clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;
            }

            ApplyStoredAuthorization(false);

            if (additionalHeaders is not null)
            {
                foreach (var header in additionalHeaders)
                {
                    _clientWebSocket.Options.SetRequestHeader(header.Key, header.Value);
                }
            }

            if (additionalSubProtocols is not null)
            {
                foreach (var subProtocol in additionalSubProtocols)
                {
                    _clientWebSocket.Options.AddSubProtocol(subProtocol);
                }
            }
        }

        private async global::System.Threading.Tasks.Task ConnectAsyncCore(
            global::System.Uri uri,
            global::System.TimeSpan? connectTimeout,
            global::System.Threading.CancellationToken cancellationToken)
        {
            global::System.Threading.CancellationTokenSource? __timeoutCancellationTokenSource = null;
            var __effectiveCancellationToken = cancellationToken;

            if (connectTimeout is not null)
            {
                __timeoutCancellationTokenSource = global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                __timeoutCancellationTokenSource.CancelAfter(connectTimeout.Value);
                __effectiveCancellationToken = __timeoutCancellationTokenSource.Token;
            }

            try
            {
                Status = AutoSDKWebSocketConnectionStatus.Connecting;
                await _clientWebSocket.ConnectAsync(uri, __effectiveCancellationToken).ConfigureAwait(false);
                Status = AutoSDKWebSocketConnectionStatus.Connected;
                Connected?.Invoke(this, global::System.EventArgs.Empty);
            }
            catch (global::System.Exception exception) when (
                exception is global::System.Net.WebSockets.WebSocketException ||
                exception is global::System.Net.Http.HttpRequestException ||
                exception is global::System.OperationCanceledException)
            {
                RaiseException(exception);
                throw;
            }
            finally
            {
                __timeoutCancellationTokenSource?.Dispose();
            }
        }

        private const string DefaultBaseUrlTemplate = "wss://api.cartesia.ai/stt/turns/websocket";


        /// <inheritdoc cref="global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __pathBuilder = new global::Cartesia.Realtime.SpeechToTextTurns.PathBuilder(
                    path: DefaultBaseUrl);

                if (_queryApiKey is not null && _queryApiKeyName is not null)
                {
                    __pathBuilder.AddRequiredParameter(_queryApiKeyName, _queryApiKey);
                }
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout);
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Connects to the WebSocket server with typed connection parameters.
        /// </summary>
        /// <param name="cartesiaVersion">API version.</param>
        /// <param name="encoding">The encoding format of the audio data. This determines how the server interprets the raw binary audio data you send.  For guidance on choosing an encoding, see [Audio Input](/build-with-cartesia/stt/audio-input).</param>
        /// <param name="model">ID of the model to use for transcription: `ink-2`, `ink-preview`.  See [Models](/build-with-cartesia/stt/latest) for details.</param>
        /// <param name="sampleRate">The sample rate of the audio in Hz.</param>
        /// <param name="keyterm">Key terms to improve the recall of specific words and phrases.  Repeat the `keyterm` query parameter to pass multiple values, up to 100 keyterms totaling 1200 characters. To boost one multi-word phrase, join the words with `%20`.  Example: `?keyterm=Ink%202&amp;keyterm=Cartesia`  See [Keyterm prompting](/use-the-api/stt/keyterms) for details.</param>
        /// <param name="turnEagerEndThreshold">Threshold below which to eager end the turn. Default: 0.4. Range: 0.3–0.6. Must stay between the end and start thresholds.  See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.</param>
        /// <param name="turnEndThreshold">Threshold below which to end the turn. Default: 0.2. Range: 0.05–0.5. Must stay below the eager end threshold.  See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.</param>
        /// <param name="turnEndTimeoutMs">Maximum amount of time in milliseconds that the model will wait after the user stops speaking before ending the turn. Default: 5600. Range: 640–11200.  See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.</param>
        /// <param name="turnStartThreshold">Threshold above which to start the turn. Default: 0.8. Range: 0.5–0.9. Must stay above the eager end threshold.  See [Configuring turn detection](/use-the-api/stt/turns#configuring-turn-detection) for details.</param>
        /// <param name="uri">Optional WebSocket endpoint override.</param>
        /// <param name="additionalHeaders">Additional headers applied before connecting.</param>
        /// <param name="additionalSubProtocols">Additional WebSocket subprotocols applied before connecting.</param>
        /// <param name="keepAliveInterval">Optional keep-alive interval.</param>
        /// <param name="connectTimeout">Optional connect timeout.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsApiVersion cartesiaVersion,
            global::Cartesia.Realtime.SpeechToTextTurns.SpeechToTextTurnsEncoding encoding,
            string model,
            int sampleRate,
            global::System.Collections.Generic.IList<string>? keyterm = default,
            double? turnEagerEndThreshold = default,
            double? turnEndThreshold = default,
            double? turnEndTimeoutMs = default,
            double? turnStartThreshold = default,
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __baseUrl = DefaultBaseUrlTemplate;
                var __pathBuilder = new global::Cartesia.Realtime.SpeechToTextTurns.PathBuilder(
                    path: __baseUrl);
                __pathBuilder
                .AddRequiredParameter("cartesia_version", cartesiaVersion.ToValueString())
                .AddRequiredParameter("encoding", encoding.ToValueString())
                .AddRequiredParameter("model", model)
                .AddRequiredParameter("sample_rate", sampleRate.ToString()!)
                .AddOptionalParameter("keyterm", keyterm, delimiter: ",", explode: true)
                .AddOptionalParameter("turn_eager_end_threshold", turnEagerEndThreshold?.ToString())
                .AddOptionalParameter("turn_end_threshold", turnEndThreshold?.ToString())
                .AddOptionalParameter("turn_end_timeout_ms", turnEndTimeoutMs?.ToString())
                .AddOptionalParameter("turn_start_threshold", turnStartThreshold?.ToString())
                ;

                if (_queryApiKey is not null && _queryApiKeyName is not null)
                {
                    __pathBuilder.AddRequiredParameter(_queryApiKeyName, _queryApiKey);
                }
                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            RememberConnectionOptions(__uri, additionalHeaders, additionalSubProtocols, keepAliveInterval, connectTimeout);
            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _clientWebSocket.Dispose();
        }

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {
            if (IsConnected)
            {
                try
                {
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: "Closing",
                        cancellationToken: default).ConfigureAwait(false);
                }
                catch (global::System.Net.WebSockets.WebSocketException)
                {
                    // Ignore errors during dispose
                }
            }
            _clientWebSocket.Dispose();
        }

        partial void Initialized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void Authorizing(
            global::System.Net.WebSockets.ClientWebSocket client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareArguments(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareRequest(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
        partial void OnReceiveException(
            global::System.Exception exception,
            ref bool rethrow);
    }
}