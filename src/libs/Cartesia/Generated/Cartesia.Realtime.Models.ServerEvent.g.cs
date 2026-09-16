#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Sent once after `session_create`, when the agent pipeline can accept audio. Reports the call record created for this session and the agent version the session is pinned to. Use `call_id` with the [calls API](/api-reference/agents/calls/get-call) to fetch the recording and transcript after the call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentSessionReadyEvent? SessionReady { get; init; }
#else
        public global::Cartesia.Realtime.AgentSessionReadyEvent? SessionReady { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionReady))]
#endif
        public bool IsSessionReady => SessionReady != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionReady(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentSessionReadyEvent? value)
        {
            value = SessionReady;
            return IsSessionReady;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionReadyEvent PickSessionReady() => IsSessionReady
            ? SessionReady!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionReady' but the value was {ToString()}.");

        /// <summary>
        /// The agent's speech. `audio` is base64-encoded audio in the format declared in `session_create.audio.input_format`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentAudioOutputEvent? AudioOutput { get; init; }
#else
        public global::Cartesia.Realtime.AgentAudioOutputEvent? AudioOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioOutput))]
#endif
        public bool IsAudioOutput => AudioOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentAudioOutputEvent? value)
        {
            value = AudioOutput;
            return IsAudioOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioOutputEvent PickAudioOutput() => IsAudioOutput
            ? AudioOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioOutput' but the value was {ToString()}.");

        /// <summary>
        /// Sent when the user starts speaking. Discard buffered agent audio and stop playback. The event can arrive while no agent audio is playing, in which case there is nothing to clear.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentAudioOutputClearEvent? AudioOutputClear { get; init; }
#else
        public global::Cartesia.Realtime.AgentAudioOutputClearEvent? AudioOutputClear { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioOutputClear))]
#endif
        public bool IsAudioOutputClear => AudioOutputClear != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioOutputClear(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentAudioOutputClearEvent? value)
        {
            value = AudioOutputClear;
            return IsAudioOutputClear;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioOutputClearEvent PickAudioOutputClear() => IsAudioOutputClear
            ? AudioOutputClear!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioOutputClear' but the value was {ToString()}.");

        /// <summary>
        /// A DTMF digit the agent sends, for clients bridging a telephony system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentDtmfOutputEvent? DtmfOutput { get; init; }
#else
        public global::Cartesia.Realtime.AgentDtmfOutputEvent? DtmfOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DtmfOutput))]
#endif
        public bool IsDtmfOutput => DtmfOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDtmfOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentDtmfOutputEvent? value)
        {
            value = DtmfOutput;
            return IsDtmfOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentDtmfOutputEvent PickDtmfOutput() => IsDtmfOutput
            ? DtmfOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DtmfOutput' but the value was {ToString()}.");

        /// <summary>
        /// The agent asks this client to run a client tool. When `expects_response` is `true`, answer with a `client_tool_result` carrying the same `tool_call_id`; the invocation stays open until a result, error, or timeout. When `false`, dispatching the action completes the invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentClientToolCallEvent? ClientToolCall { get; init; }
#else
        public global::Cartesia.Realtime.AgentClientToolCallEvent? ClientToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolCall))]
#endif
        public bool IsClientToolCall => ClientToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentClientToolCallEvent? value)
        {
            value = ClientToolCall;
            return IsClientToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentClientToolCallEvent PickClientToolCall() => IsClientToolCall
            ? ClientToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolCall' but the value was {ToString()}.");

        /// <summary>
        /// Sent when the user starts speaking or the agent starts responding. `turn` comes from a single counter shared by both roles, starting at 1 and strictly increasing over the call, so `turn` alone identifies a turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentTurnStartedEvent? TurnStarted { get; init; }
#else
        public global::Cartesia.Realtime.AgentTurnStartedEvent? TurnStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnStarted))]
#endif
        public bool IsTurnStarted => TurnStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentTurnStartedEvent? value)
        {
            value = TurnStarted;
            return IsTurnStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnStartedEvent PickTurnStarted() => IsTurnStarted
            ? TurnStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnStarted' but the value was {ToString()}.");

        /// <summary>
        /// Sent as the agent speaks, carrying the text spoken since the previous delta, typically one word at a time. Deltas include separator spaces, so build the running text by appending `text` verbatim. The user's speech is not streamed incrementally. It arrives as finalized text in `turn_ended`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? TurnOutputTextDelta { get; init; }
#else
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? TurnOutputTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnOutputTextDelta))]
#endif
        public bool IsTurnOutputTextDelta => TurnOutputTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? value)
        {
            value = TurnOutputTextDelta;
            return IsTurnOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent PickTurnOutputTextDelta() => IsTurnOutputTextDelta
            ? TurnOutputTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnOutputTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Sent when a turn finishes, with the complete final text for the turn. This is the version to store and display. The events for a single turn always arrive in order: `turn_started`, then any `turn_output_text_delta` events, then `turn_ended`. If the agent hangs up mid-turn, the connection closes without a final `turn_ended`; treat the close as ending any open turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentTurnEndedEvent? TurnEnded { get; init; }
#else
        public global::Cartesia.Realtime.AgentTurnEndedEvent? TurnEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnEnded))]
#endif
        public bool IsTurnEnded => TurnEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentTurnEndedEvent? value)
        {
            value = TurnEnded;
            return IsTurnEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnEndedEvent PickTurnEnded() => IsTurnEnded
            ? TurnEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnEnded' but the value was {ToString()}.");

        /// <summary>
        /// Reports a problem with the session or an event you sent. When `fatal` is `false`, the server ignores that event and keeps the connection open. When `fatal` is `true`, it closes the connection with code 1008 for client or protocol errors, or 1011 if the agent fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.AgentErrorEvent? Error { get; init; }
#else
        public global::Cartesia.Realtime.AgentErrorEvent? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.AgentErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentErrorEvent PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentSessionReadyEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentSessionReadyEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentSessionReadyEvent?(ServerEvent @this) => @this.SessionReady;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentSessionReadyEvent? value)
        {
            SessionReady = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromSessionReady(global::Cartesia.Realtime.AgentSessionReadyEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentAudioOutputEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentAudioOutputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentAudioOutputEvent?(ServerEvent @this) => @this.AudioOutput;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentAudioOutputEvent? value)
        {
            AudioOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromAudioOutput(global::Cartesia.Realtime.AgentAudioOutputEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentAudioOutputClearEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentAudioOutputClearEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentAudioOutputClearEvent?(ServerEvent @this) => @this.AudioOutputClear;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentAudioOutputClearEvent? value)
        {
            AudioOutputClear = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromAudioOutputClear(global::Cartesia.Realtime.AgentAudioOutputClearEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentDtmfOutputEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentDtmfOutputEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentDtmfOutputEvent?(ServerEvent @this) => @this.DtmfOutput;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentDtmfOutputEvent? value)
        {
            DtmfOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromDtmfOutput(global::Cartesia.Realtime.AgentDtmfOutputEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentClientToolCallEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentClientToolCallEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentClientToolCallEvent?(ServerEvent @this) => @this.ClientToolCall;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentClientToolCallEvent? value)
        {
            ClientToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromClientToolCall(global::Cartesia.Realtime.AgentClientToolCallEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentTurnStartedEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentTurnStartedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentTurnStartedEvent?(ServerEvent @this) => @this.TurnStarted;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentTurnStartedEvent? value)
        {
            TurnStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnStarted(global::Cartesia.Realtime.AgentTurnStartedEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent?(ServerEvent @this) => @this.TurnOutputTextDelta;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? value)
        {
            TurnOutputTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnOutputTextDelta(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentTurnEndedEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentTurnEndedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentTurnEndedEvent?(ServerEvent @this) => @this.TurnEnded;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentTurnEndedEvent? value)
        {
            TurnEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnEnded(global::Cartesia.Realtime.AgentTurnEndedEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.AgentErrorEvent value) => new ServerEvent((global::Cartesia.Realtime.AgentErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.AgentErrorEvent?(ServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.AgentErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromError(global::Cartesia.Realtime.AgentErrorEvent? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(
            global::Cartesia.Realtime.ServerEventDiscriminatorType? type,
            global::Cartesia.Realtime.AgentSessionReadyEvent? sessionReady,
            global::Cartesia.Realtime.AgentAudioOutputEvent? audioOutput,
            global::Cartesia.Realtime.AgentAudioOutputClearEvent? audioOutputClear,
            global::Cartesia.Realtime.AgentDtmfOutputEvent? dtmfOutput,
            global::Cartesia.Realtime.AgentClientToolCallEvent? clientToolCall,
            global::Cartesia.Realtime.AgentTurnStartedEvent? turnStarted,
            global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? turnOutputTextDelta,
            global::Cartesia.Realtime.AgentTurnEndedEvent? turnEnded,
            global::Cartesia.Realtime.AgentErrorEvent? error
            )
        {
            Type = type;

            SessionReady = sessionReady;
            AudioOutput = audioOutput;
            AudioOutputClear = audioOutputClear;
            DtmfOutput = dtmfOutput;
            ClientToolCall = clientToolCall;
            TurnStarted = turnStarted;
            TurnOutputTextDelta = turnOutputTextDelta;
            TurnEnded = turnEnded;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            TurnEnded as object ??
            TurnOutputTextDelta as object ??
            TurnStarted as object ??
            ClientToolCall as object ??
            DtmfOutput as object ??
            AudioOutputClear as object ??
            AudioOutput as object ??
            SessionReady as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionReady?.ToString() ??
            AudioOutput?.ToString() ??
            AudioOutputClear?.ToString() ??
            DtmfOutput?.ToString() ??
            ClientToolCall?.ToString() ??
            TurnStarted?.ToString() ??
            TurnOutputTextDelta?.ToString() ??
            TurnEnded?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && IsTurnOutputTextDelta && !IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && IsTurnEnded && !IsError || !IsSessionReady && !IsAudioOutput && !IsAudioOutputClear && !IsDtmfOutput && !IsClientToolCall && !IsTurnStarted && !IsTurnOutputTextDelta && !IsTurnEnded && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.Realtime.AgentSessionReadyEvent, TResult>? sessionReady = null,
            global::System.Func<global::Cartesia.Realtime.AgentAudioOutputEvent, TResult>? audioOutput = null,
            global::System.Func<global::Cartesia.Realtime.AgentAudioOutputClearEvent, TResult>? audioOutputClear = null,
            global::System.Func<global::Cartesia.Realtime.AgentDtmfOutputEvent, TResult>? dtmfOutput = null,
            global::System.Func<global::Cartesia.Realtime.AgentClientToolCallEvent, TResult>? clientToolCall = null,
            global::System.Func<global::Cartesia.Realtime.AgentTurnStartedEvent, TResult>? turnStarted = null,
            global::System.Func<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent, TResult>? turnOutputTextDelta = null,
            global::System.Func<global::Cartesia.Realtime.AgentTurnEndedEvent, TResult>? turnEnded = null,
            global::System.Func<global::Cartesia.Realtime.AgentErrorEvent, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionReady && sessionReady != null)
            {
                return sessionReady(SessionReady!);
            }
            else if (IsAudioOutput && audioOutput != null)
            {
                return audioOutput(AudioOutput!);
            }
            else if (IsAudioOutputClear && audioOutputClear != null)
            {
                return audioOutputClear(AudioOutputClear!);
            }
            else if (IsDtmfOutput && dtmfOutput != null)
            {
                return dtmfOutput(DtmfOutput!);
            }
            else if (IsClientToolCall && clientToolCall != null)
            {
                return clientToolCall(ClientToolCall!);
            }
            else if (IsTurnStarted && turnStarted != null)
            {
                return turnStarted(TurnStarted!);
            }
            else if (IsTurnOutputTextDelta && turnOutputTextDelta != null)
            {
                return turnOutputTextDelta(TurnOutputTextDelta!);
            }
            else if (IsTurnEnded && turnEnded != null)
            {
                return turnEnded(TurnEnded!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.Realtime.AgentSessionReadyEvent>? sessionReady = null,

            global::System.Action<global::Cartesia.Realtime.AgentAudioOutputEvent>? audioOutput = null,

            global::System.Action<global::Cartesia.Realtime.AgentAudioOutputClearEvent>? audioOutputClear = null,

            global::System.Action<global::Cartesia.Realtime.AgentDtmfOutputEvent>? dtmfOutput = null,

            global::System.Action<global::Cartesia.Realtime.AgentClientToolCallEvent>? clientToolCall = null,

            global::System.Action<global::Cartesia.Realtime.AgentTurnStartedEvent>? turnStarted = null,

            global::System.Action<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent>? turnOutputTextDelta = null,

            global::System.Action<global::Cartesia.Realtime.AgentTurnEndedEvent>? turnEnded = null,

            global::System.Action<global::Cartesia.Realtime.AgentErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionReady)
            {
                sessionReady?.Invoke(SessionReady!);
            }
            else if (IsAudioOutput)
            {
                audioOutput?.Invoke(AudioOutput!);
            }
            else if (IsAudioOutputClear)
            {
                audioOutputClear?.Invoke(AudioOutputClear!);
            }
            else if (IsDtmfOutput)
            {
                dtmfOutput?.Invoke(DtmfOutput!);
            }
            else if (IsClientToolCall)
            {
                clientToolCall?.Invoke(ClientToolCall!);
            }
            else if (IsTurnStarted)
            {
                turnStarted?.Invoke(TurnStarted!);
            }
            else if (IsTurnOutputTextDelta)
            {
                turnOutputTextDelta?.Invoke(TurnOutputTextDelta!);
            }
            else if (IsTurnEnded)
            {
                turnEnded?.Invoke(TurnEnded!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.Realtime.AgentSessionReadyEvent>? sessionReady = null,
            global::System.Action<global::Cartesia.Realtime.AgentAudioOutputEvent>? audioOutput = null,
            global::System.Action<global::Cartesia.Realtime.AgentAudioOutputClearEvent>? audioOutputClear = null,
            global::System.Action<global::Cartesia.Realtime.AgentDtmfOutputEvent>? dtmfOutput = null,
            global::System.Action<global::Cartesia.Realtime.AgentClientToolCallEvent>? clientToolCall = null,
            global::System.Action<global::Cartesia.Realtime.AgentTurnStartedEvent>? turnStarted = null,
            global::System.Action<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent>? turnOutputTextDelta = null,
            global::System.Action<global::Cartesia.Realtime.AgentTurnEndedEvent>? turnEnded = null,
            global::System.Action<global::Cartesia.Realtime.AgentErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionReady)
            {
                sessionReady?.Invoke(SessionReady!);
            }
            else if (IsAudioOutput)
            {
                audioOutput?.Invoke(AudioOutput!);
            }
            else if (IsAudioOutputClear)
            {
                audioOutputClear?.Invoke(AudioOutputClear!);
            }
            else if (IsDtmfOutput)
            {
                dtmfOutput?.Invoke(DtmfOutput!);
            }
            else if (IsClientToolCall)
            {
                clientToolCall?.Invoke(ClientToolCall!);
            }
            else if (IsTurnStarted)
            {
                turnStarted?.Invoke(TurnStarted!);
            }
            else if (IsTurnOutputTextDelta)
            {
                turnOutputTextDelta?.Invoke(TurnOutputTextDelta!);
            }
            else if (IsTurnEnded)
            {
                turnEnded?.Invoke(TurnEnded!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionReady,
                typeof(global::Cartesia.Realtime.AgentSessionReadyEvent),
                AudioOutput,
                typeof(global::Cartesia.Realtime.AgentAudioOutputEvent),
                AudioOutputClear,
                typeof(global::Cartesia.Realtime.AgentAudioOutputClearEvent),
                DtmfOutput,
                typeof(global::Cartesia.Realtime.AgentDtmfOutputEvent),
                ClientToolCall,
                typeof(global::Cartesia.Realtime.AgentClientToolCallEvent),
                TurnStarted,
                typeof(global::Cartesia.Realtime.AgentTurnStartedEvent),
                TurnOutputTextDelta,
                typeof(global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent),
                TurnEnded,
                typeof(global::Cartesia.Realtime.AgentTurnEndedEvent),
                Error,
                typeof(global::Cartesia.Realtime.AgentErrorEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentSessionReadyEvent?>.Default.Equals(SessionReady, other.SessionReady) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentAudioOutputEvent?>.Default.Equals(AudioOutput, other.AudioOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentAudioOutputClearEvent?>.Default.Equals(AudioOutputClear, other.AudioOutputClear) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentDtmfOutputEvent?>.Default.Equals(DtmfOutput, other.DtmfOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentClientToolCallEvent?>.Default.Equals(ClientToolCall, other.ClientToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentTurnStartedEvent?>.Default.Equals(TurnStarted, other.TurnStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent?>.Default.Equals(TurnOutputTextDelta, other.TurnOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentTurnEndedEvent?>.Default.Equals(TurnEnded, other.TurnEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.AgentErrorEvent?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
