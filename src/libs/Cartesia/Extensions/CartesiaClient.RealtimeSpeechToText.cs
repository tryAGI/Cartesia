#nullable enable

using System.Buffers;
using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cartesia;

/// <summary>
/// Realtime speech-to-text WebSocket helpers for Cartesia.
/// </summary>
public sealed partial class CartesiaClient
{
    /// <summary>
    /// Default Cartesia API version for realtime speech-to-text WebSocket endpoints.
    /// </summary>
    public const string DefaultRealtimeSttCartesiaVersion = "2026-03-01";

    /// <summary>
    /// Connects to realtime speech-to-text with automatic turn finalization.
    /// This endpoint supports <see cref="STTAutoFinalizeModel.Ink2"/>.
    /// </summary>
    /// <param name="queryParams">Connection query parameters.</param>
    /// <param name="cartesiaVersion">Cartesia API version to use for the WebSocket connection.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async Task<CartesiaRealtimeSttAutoSession> ConnectRealtimeSttAutoAsync(
        STTAutoFinalizeWebSocketQueryParams queryParams,
        string cartesiaVersion = DefaultRealtimeSttCartesiaVersion,
        CancellationToken cancellationToken = default)
    {
        _ = queryParams ?? throw new ArgumentNullException(nameof(queryParams));

        var webSocket = new ClientWebSocket();
        try
        {
            var uri = BuildRealtimeSttWebSocketUri(
                "stt/turns/websocket",
                CreateAutoFinalizeQuery(queryParams, cartesiaVersion));

            ApplyWebSocketHeaders(webSocket, cartesiaVersion);
            await webSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);

            return new CartesiaRealtimeSttAutoSession(webSocket, JsonSerializerContext);
        }
        catch
        {
            webSocket.Dispose();
            throw;
        }
    }

    /// <summary>
    /// Connects to realtime speech-to-text with automatic turn finalization.
    /// This overload defaults to the stable <see cref="STTAutoFinalizeModel.Ink2"/> model.
    /// </summary>
    /// <param name="encoding">Audio encoding for binary audio frames.</param>
    /// <param name="sampleRate">Audio sample rate in Hz.</param>
    /// <param name="model">Realtime STT auto-finalize model.</param>
    /// <param name="cartesiaVersion">Cartesia API version to use for the WebSocket connection.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public Task<CartesiaRealtimeSttAutoSession> ConnectRealtimeSttAutoAsync(
        STTEncoding encoding,
        int sampleRate,
        STTAutoFinalizeModel model = STTAutoFinalizeModel.Ink2,
        string cartesiaVersion = DefaultRealtimeSttCartesiaVersion,
        CancellationToken cancellationToken = default)
    {
        return ConnectRealtimeSttAutoAsync(
            new STTAutoFinalizeWebSocketQueryParams(
                encoding: encoding,
                sampleRate: sampleRate,
                model: model),
            cartesiaVersion,
            cancellationToken);
    }

    /// <summary>
    /// Connects to realtime speech-to-text with caller-controlled finalization.
    /// This endpoint supports <see cref="STTManualFinalizeModel.Ink2"/> and older Ink Whisper models.
    /// </summary>
    /// <param name="queryParams">Connection query parameters.</param>
    /// <param name="cartesiaVersion">Cartesia API version to use for the WebSocket connection.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async Task<CartesiaRealtimeSttManualSession> ConnectRealtimeSttManualAsync(
        STTManualFinalizeWebSocketQueryParams queryParams,
        string cartesiaVersion = DefaultRealtimeSttCartesiaVersion,
        CancellationToken cancellationToken = default)
    {
        _ = queryParams ?? throw new ArgumentNullException(nameof(queryParams));

        var webSocket = new ClientWebSocket();
        try
        {
            var uri = BuildRealtimeSttWebSocketUri(
                "stt/websocket",
                CreateManualFinalizeQuery(queryParams, cartesiaVersion));

            ApplyWebSocketHeaders(webSocket, cartesiaVersion);
            await webSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);

            return new CartesiaRealtimeSttManualSession(webSocket, JsonSerializerContext);
        }
        catch
        {
            webSocket.Dispose();
            throw;
        }
    }

    /// <summary>
    /// Connects to realtime speech-to-text with caller-controlled finalization.
    /// This overload defaults to the stable <see cref="STTManualFinalizeModel.Ink2"/> model.
    /// </summary>
    /// <param name="encoding">Audio encoding for binary audio frames.</param>
    /// <param name="sampleRate">Audio sample rate in Hz.</param>
    /// <param name="model">Realtime STT manual-finalize model.</param>
    /// <param name="language">Optional input audio language. Ink 2 currently supports English.</param>
    /// <param name="minVolume">Optional silence threshold for Ink Whisper models.</param>
    /// <param name="maxSilenceDurationSecs">Optional silence duration for Ink Whisper models.</param>
    /// <param name="cartesiaVersion">Cartesia API version to use for the WebSocket connection.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public Task<CartesiaRealtimeSttManualSession> ConnectRealtimeSttManualAsync(
        STTEncoding encoding,
        int sampleRate,
        STTManualFinalizeModel model = STTManualFinalizeModel.Ink2,
        STTManualFinalizeWebSocketQueryParamsLanguage? language = default,
        double? minVolume = default,
        double? maxSilenceDurationSecs = default,
        string cartesiaVersion = DefaultRealtimeSttCartesiaVersion,
        CancellationToken cancellationToken = default)
    {
        return ConnectRealtimeSttManualAsync(
            new STTManualFinalizeWebSocketQueryParams(
                model: model,
                encoding: encoding,
                sampleRate: sampleRate,
                language: language,
                minVolume: minVolume,
                maxSilenceDurationSecs: maxSilenceDurationSecs),
            cartesiaVersion,
            cancellationToken);
    }

    private Uri BuildRealtimeSttWebSocketUri(
        string relativePath,
        IEnumerable<KeyValuePair<string, string>> queryParameters)
    {
        var baseUri = BaseUri ?? new Uri(DefaultBaseUrl);
        var builder = new UriBuilder(baseUri)
        {
            Scheme = baseUri.Scheme switch
            {
                "https" => "wss",
                "http" => "ws",
                _ => baseUri.Scheme,
            },
        };

        var basePath = builder.Path.TrimEnd('/');
        builder.Path = string.IsNullOrEmpty(basePath) || basePath == "/"
            ? relativePath
            : string.Concat(basePath, "/", relativePath);

        builder.Query = BuildQueryString(queryParameters);
        return builder.Uri;
    }

    private void ApplyWebSocketHeaders(
        ClientWebSocket webSocket,
        string cartesiaVersion)
    {
        _ = webSocket ?? throw new ArgumentNullException(nameof(webSocket));

        webSocket.Options.SetRequestHeader("Cartesia-Version", cartesiaVersion);

        foreach (var header in Options.Headers)
        {
            webSocket.Options.SetRequestHeader(header.Key, header.Value);
        }

        foreach (var authorization in Authorizations)
        {
            if (authorization.Type == "Http" &&
                authorization.Value is { Length: > 0 })
            {
                webSocket.Options.SetRequestHeader(
                    "Authorization",
                    string.Concat(authorization.Name, " ", authorization.Value));

                if (string.Equals(authorization.Name, "Bearer", StringComparison.Ordinal))
                {
                    webSocket.Options.SetRequestHeader("X-API-Key", authorization.Value);
                }
            }
            else if (authorization.Type == "ApiKey" &&
                     authorization.Location == "Header" &&
                     authorization.Name is { Length: > 0 } &&
                     authorization.Value is { Length: > 0 })
            {
                webSocket.Options.SetRequestHeader(authorization.Name, authorization.Value);
            }
        }
    }

    private IEnumerable<KeyValuePair<string, string>> CreateAutoFinalizeQuery(
        STTAutoFinalizeWebSocketQueryParams queryParams,
        string cartesiaVersion)
    {
        foreach (var queryParameter in Options.QueryParameters)
        {
            yield return queryParameter;
        }

        foreach (var queryParameter in CreateAdditionalQuery(queryParams.AdditionalProperties))
        {
            yield return queryParameter;
        }

        yield return new KeyValuePair<string, string>("model", queryParams.Model.ToValueString());
        yield return new KeyValuePair<string, string>("encoding", queryParams.Encoding.ToValueString());
        yield return new KeyValuePair<string, string>(
            "sample_rate",
            queryParams.SampleRate.ToString(CultureInfo.InvariantCulture));
        yield return new KeyValuePair<string, string>("cartesia_version", cartesiaVersion);
    }

    private IEnumerable<KeyValuePair<string, string>> CreateManualFinalizeQuery(
        STTManualFinalizeWebSocketQueryParams queryParams,
        string cartesiaVersion)
    {
        foreach (var queryParameter in Options.QueryParameters)
        {
            yield return queryParameter;
        }

        foreach (var queryParameter in CreateAdditionalQuery(queryParams.AdditionalProperties))
        {
            yield return queryParameter;
        }

        yield return new KeyValuePair<string, string>("model", queryParams.Model.ToValueString());
        yield return new KeyValuePair<string, string>("encoding", queryParams.Encoding.ToValueString());
        yield return new KeyValuePair<string, string>(
            "sample_rate",
            queryParams.SampleRate.ToString(CultureInfo.InvariantCulture));

        if (queryParams.Language is { } language)
        {
            yield return new KeyValuePair<string, string>("language", language.ToValueString());
        }

        if (queryParams.MinVolume is { } minVolume)
        {
            yield return new KeyValuePair<string, string>(
                "min_volume",
                minVolume.ToString(CultureInfo.InvariantCulture));
        }

        if (queryParams.MaxSilenceDurationSecs is { } maxSilenceDurationSecs)
        {
            yield return new KeyValuePair<string, string>(
                "max_silence_duration_secs",
                maxSilenceDurationSecs.ToString(CultureInfo.InvariantCulture));
        }

        yield return new KeyValuePair<string, string>("cartesia_version", cartesiaVersion);
    }

    private static IEnumerable<KeyValuePair<string, string>> CreateAdditionalQuery(
        IEnumerable<KeyValuePair<string, object>> additionalProperties)
    {
        foreach (var property in additionalProperties)
        {
            if (property.Value is null)
            {
                continue;
            }

            var value = Convert.ToString(property.Value, CultureInfo.InvariantCulture);
            if (value is { Length: > 0 })
            {
                yield return new KeyValuePair<string, string>(property.Key, value);
            }
        }
    }

    private static string BuildQueryString(
        IEnumerable<KeyValuePair<string, string>> queryParameters)
    {
        var builder = new StringBuilder();
        foreach (var queryParameter in queryParameters)
        {
            if (builder.Length > 0)
            {
                builder.Append('&');
            }

            builder
                .Append(Uri.EscapeDataString(queryParameter.Key))
                .Append('=')
                .Append(Uri.EscapeDataString(queryParameter.Value));
        }

        return builder.ToString();
    }
}

/// <summary>
/// Realtime speech-to-text session with automatic turn finalization.
/// </summary>
public sealed class CartesiaRealtimeSttAutoSession : IAsyncDisposable
{
    private readonly ClientWebSocket _webSocket;
    private readonly System.Text.Json.Serialization.JsonSerializerContext _jsonSerializerContext;

    internal CartesiaRealtimeSttAutoSession(
        ClientWebSocket webSocket,
        System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
    {
        _webSocket = webSocket ?? throw new ArgumentNullException(nameof(webSocket));
        _jsonSerializerContext = jsonSerializerContext ?? throw new ArgumentNullException(nameof(jsonSerializerContext));
    }

    /// <summary>
    /// Current WebSocket state.
    /// </summary>
    public WebSocketState State => _webSocket.State;

    /// <summary>
    /// Sends raw audio bytes as a WebSocket binary message.
    /// </summary>
    /// <param name="audio">Audio bytes encoded according to the connection query parameters.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async Task SendAudioAsync(
        ReadOnlyMemory<byte> audio,
        CancellationToken cancellationToken = default)
    {
        EnsureCanSend();
        await _webSocket
            .SendAsync(
                audio,
                WebSocketMessageType.Binary,
                endOfMessage: true,
                cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Sends Cartesia's close command. The server processes buffered audio before closing.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public Task SendCloseCommandAsync(CancellationToken cancellationToken = default)
    {
        var command = new STTAutoFinalizeCloseCommand(STTAutoFinalizeCloseCommandType.Close);
        return SendTextAsync(command.ToJson(_jsonSerializerContext), cancellationToken);
    }

    /// <summary>
    /// Receives the next server event. Returns <c>null</c> when the server closes the WebSocket.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async ValueTask<STTAutoFinalizeWebSocketResponse?> ReceiveResponseAsync(
        CancellationToken cancellationToken = default)
    {
        var message = await ReceiveTextMessageAsync(_webSocket, cancellationToken).ConfigureAwait(false);
        return message is null
            ? null
            : STTAutoFinalizeWebSocketResponse.FromJson(message, _jsonSerializerContext);
    }

    /// <summary>
    /// Receives server events until the WebSocket closes.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async IAsyncEnumerable<STTAutoFinalizeWebSocketResponse> ReceiveResponsesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        while (true)
        {
            var response = await ReceiveResponseAsync(cancellationToken).ConfigureAwait(false);
            if (response is null)
            {
                yield break;
            }

            yield return response.Value;
        }
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_webSocket.State is WebSocketState.Open or WebSocketState.CloseReceived)
        {
            await _webSocket.CloseAsync(
                WebSocketCloseStatus.NormalClosure,
                "Disposing",
                CancellationToken.None).ConfigureAwait(false);
        }

        _webSocket.Dispose();
    }

    private async Task SendTextAsync(
        string text,
        CancellationToken cancellationToken)
    {
        EnsureCanSend();
        await _webSocket
            .SendAsync(
                Encoding.UTF8.GetBytes(text),
                WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken)
            .ConfigureAwait(false);
    }

    private void EnsureCanSend()
    {
        if (_webSocket.State != WebSocketState.Open)
        {
            throw new InvalidOperationException($"The Cartesia WebSocket is not open. Current state: {_webSocket.State}.");
        }
    }

    internal static async ValueTask<string?> ReceiveTextMessageAsync(
        ClientWebSocket webSocket,
        CancellationToken cancellationToken)
    {
        _ = webSocket ?? throw new ArgumentNullException(nameof(webSocket));

        var rentedBuffer = ArrayPool<byte>.Shared.Rent(8192);
        try
        {
            using var message = new MemoryStream();
            while (true)
            {
                var result = await webSocket
                    .ReceiveAsync(rentedBuffer, cancellationToken)
                    .ConfigureAwait(false);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    return null;
                }

                if (result.MessageType != WebSocketMessageType.Text)
                {
                    throw new InvalidOperationException($"Expected a text WebSocket message, but received {result.MessageType}.");
                }

                await message
                    .WriteAsync(rentedBuffer.AsMemory(0, result.Count), cancellationToken)
                    .ConfigureAwait(false);

                if (result.EndOfMessage)
                {
                    return Encoding.UTF8.GetString(message.GetBuffer(), 0, checked((int)message.Length));
                }
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(rentedBuffer);
        }
    }
}

/// <summary>
/// Realtime speech-to-text session with caller-controlled finalization.
/// </summary>
public sealed class CartesiaRealtimeSttManualSession : IAsyncDisposable
{
    private readonly ClientWebSocket _webSocket;
    private readonly System.Text.Json.Serialization.JsonSerializerContext _jsonSerializerContext;

    internal CartesiaRealtimeSttManualSession(
        ClientWebSocket webSocket,
        System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
    {
        _webSocket = webSocket ?? throw new ArgumentNullException(nameof(webSocket));
        _jsonSerializerContext = jsonSerializerContext ?? throw new ArgumentNullException(nameof(jsonSerializerContext));
    }

    /// <summary>
    /// Current WebSocket state.
    /// </summary>
    public WebSocketState State => _webSocket.State;

    /// <summary>
    /// Sends raw audio bytes as a WebSocket binary message.
    /// </summary>
    /// <param name="audio">Audio bytes encoded according to the connection query parameters.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async Task SendAudioAsync(
        ReadOnlyMemory<byte> audio,
        CancellationToken cancellationToken = default)
    {
        EnsureCanSend();
        await _webSocket
            .SendAsync(
                audio,
                WebSocketMessageType.Binary,
                endOfMessage: true,
                cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Sends the manual finalization command and asks Cartesia to emit finalized transcript events.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public Task SendFinalizeCommandAsync(CancellationToken cancellationToken = default)
    {
        return SendCommandAsync(STTManualFinalizeWebSocketRequest.Finalize, cancellationToken);
    }

    /// <summary>
    /// Sends Cartesia's close command. The server flushes buffered audio before closing.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public Task SendCloseCommandAsync(CancellationToken cancellationToken = default)
    {
        return SendCommandAsync(STTManualFinalizeWebSocketRequest.Close, cancellationToken);
    }

    /// <summary>
    /// Receives the next server event. Returns <c>null</c> when the server closes the WebSocket.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async ValueTask<STTManualFinalizeWebSocketResponse?> ReceiveResponseAsync(
        CancellationToken cancellationToken = default)
    {
        var message = await CartesiaRealtimeSttAutoSession
            .ReceiveTextMessageAsync(_webSocket, cancellationToken)
            .ConfigureAwait(false);

        return message is null
            ? null
            : STTManualFinalizeWebSocketResponse.FromJson(message, _jsonSerializerContext);
    }

    /// <summary>
    /// Receives server events until the WebSocket closes.
    /// </summary>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    public async IAsyncEnumerable<STTManualFinalizeWebSocketResponse> ReceiveResponsesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        while (true)
        {
            var response = await ReceiveResponseAsync(cancellationToken).ConfigureAwait(false);
            if (response is null)
            {
                yield break;
            }

            yield return response.Value;
        }
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_webSocket.State is WebSocketState.Open or WebSocketState.CloseReceived)
        {
            await _webSocket.CloseAsync(
                WebSocketCloseStatus.NormalClosure,
                "Disposing",
                CancellationToken.None).ConfigureAwait(false);
        }

        _webSocket.Dispose();
    }

    private async Task SendCommandAsync(
        STTManualFinalizeWebSocketRequest command,
        CancellationToken cancellationToken)
    {
        EnsureCanSend();
        await _webSocket
            .SendAsync(
                Encoding.UTF8.GetBytes(command.ToValueString()),
                WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken)
            .ConfigureAwait(false);
    }

    private void EnsureCanSend()
    {
        if (_webSocket.State != WebSocketState.Open)
        {
            throw new InvalidOperationException($"The Cartesia WebSocket is not open. Current state: {_webSocket.State}.");
        }
    }
}
