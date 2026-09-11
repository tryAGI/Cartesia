#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia.Realtime.SpeechToTextTurns
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Fires once when the WebSocket connection is established.<br/>
        /// You do not need to wait for this event before sending audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? Connected { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? Connected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connected))]
#endif
        public bool IsConnected => Connected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? value)
        {
            value = Connected;
            return IsConnected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected PickConnected() => IsConnected
            ? Connected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connected' but the value was {ToString()}.");

        /// <summary>
        /// Marks the start of a user turn. Fires quickly after the user begins speaking.<br/>
        /// This event can be used to interrupt your agent to avoid talking over the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? TurnStart { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? TurnStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnStart))]
#endif
        public bool IsTurnStart => TurnStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? value)
        {
            value = TurnStart;
            return IsTurnStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart PickTurnStart() => IsTurnStart
            ? TurnStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnStart' but the value was {ToString()}.");

        /// <summary>
        /// Fires repeatedly as the model transcribes the current user turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? TurnUpdate { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? TurnUpdate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnUpdate))]
#endif
        public bool IsTurnUpdate => TurnUpdate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? value)
        {
            value = TurnUpdate;
            return IsTurnUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate PickTurnUpdate() => IsTurnUpdate
            ? TurnUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnUpdate' but the value was {ToString()}.");

        /// <summary>
        /// Fires when the model predicts that the user might be done speaking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? TurnEagerEnd { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? TurnEagerEnd { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnEagerEnd))]
#endif
        public bool IsTurnEagerEnd => TurnEagerEnd != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnEagerEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? value)
        {
            value = TurnEagerEnd;
            return IsTurnEagerEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd PickTurnEagerEnd() => IsTurnEagerEnd
            ? TurnEagerEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnEagerEnd' but the value was {ToString()}.");

        /// <summary>
        /// Fires after `turn.eager_end` if the user turn has not actually ended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? TurnResume { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? TurnResume { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnResume))]
#endif
        public bool IsTurnResume => TurnResume != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnResume(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? value)
        {
            value = TurnResume;
            return IsTurnResume;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume PickTurnResume() => IsTurnResume
            ? TurnResume!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnResume' but the value was {ToString()}.");

        /// <summary>
        /// Marks the end of a user turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? TurnEnd { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? TurnEnd { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnEnd))]
#endif
        public bool IsTurnEnd => TurnEnd != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTurnEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? value)
        {
            value = TurnEnd;
            return IsTurnEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd PickTurnEnd() => IsTurnEnd
            ? TurnEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnEnd' but the value was {ToString()}.");

        /// <summary>
        /// Error information for STT WebSocket connections.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? Error { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? Error { get; }
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
            out global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected?(ServerEvent @this) => @this.Connected;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? value)
        {
            Connected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromConnected(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart?(ServerEvent @this) => @this.TurnStart;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? value)
        {
            TurnStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnStart(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate?(ServerEvent @this) => @this.TurnUpdate;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? value)
        {
            TurnUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnUpdate(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd?(ServerEvent @this) => @this.TurnEagerEnd;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? value)
        {
            TurnEagerEnd = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnEagerEnd(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume?(ServerEvent @this) => @this.TurnResume;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? value)
        {
            TurnResume = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnResume(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd?(ServerEvent @this) => @this.TurnEnd;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? value)
        {
            TurnEnd = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTurnEnd(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse value) => new ServerEvent((global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse?(ServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromError(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(
            global::Cartesia.Realtime.SpeechToTextTurns.ServerEventDiscriminatorType? type,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected? connected,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart? turnStart,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate? turnUpdate,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd? turnEagerEnd,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume? turnResume,
            global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd? turnEnd,
            global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse? error
            )
        {
            Type = type;

            Connected = connected;
            TurnStart = turnStart;
            TurnUpdate = turnUpdate;
            TurnEagerEnd = turnEagerEnd;
            TurnResume = turnResume;
            TurnEnd = turnEnd;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            TurnEnd as object ??
            TurnResume as object ??
            TurnEagerEnd as object ??
            TurnUpdate as object ??
            TurnStart as object ??
            Connected as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Connected?.ToString() ??
            TurnStart?.ToString() ??
            TurnUpdate?.ToString() ??
            TurnEagerEnd?.ToString() ??
            TurnResume?.ToString() ??
            TurnEnd?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConnected && !IsTurnStart && !IsTurnUpdate && !IsTurnEagerEnd && !IsTurnResume && !IsTurnEnd && !IsError || !IsConnected && IsTurnStart && !IsTurnUpdate && !IsTurnEagerEnd && !IsTurnResume && !IsTurnEnd && !IsError || !IsConnected && !IsTurnStart && IsTurnUpdate && !IsTurnEagerEnd && !IsTurnResume && !IsTurnEnd && !IsError || !IsConnected && !IsTurnStart && !IsTurnUpdate && IsTurnEagerEnd && !IsTurnResume && !IsTurnEnd && !IsError || !IsConnected && !IsTurnStart && !IsTurnUpdate && !IsTurnEagerEnd && IsTurnResume && !IsTurnEnd && !IsError || !IsConnected && !IsTurnStart && !IsTurnUpdate && !IsTurnEagerEnd && !IsTurnResume && IsTurnEnd && !IsError || !IsConnected && !IsTurnStart && !IsTurnUpdate && !IsTurnEagerEnd && !IsTurnResume && !IsTurnEnd && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected, TResult>? connected = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart, TResult>? turnStart = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate, TResult>? turnUpdate = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd, TResult>? turnEagerEnd = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume, TResult>? turnResume = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd, TResult>? turnEnd = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnected && connected != null)
            {
                return connected(Connected!);
            }
            else if (IsTurnStart && turnStart != null)
            {
                return turnStart(TurnStart!);
            }
            else if (IsTurnUpdate && turnUpdate != null)
            {
                return turnUpdate(TurnUpdate!);
            }
            else if (IsTurnEagerEnd && turnEagerEnd != null)
            {
                return turnEagerEnd(TurnEagerEnd!);
            }
            else if (IsTurnResume && turnResume != null)
            {
                return turnResume(TurnResume!);
            }
            else if (IsTurnEnd && turnEnd != null)
            {
                return turnEnd(TurnEnd!);
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
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected>? connected = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart>? turnStart = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate>? turnUpdate = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd>? turnEagerEnd = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume>? turnResume = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd>? turnEnd = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnected)
            {
                connected?.Invoke(Connected!);
            }
            else if (IsTurnStart)
            {
                turnStart?.Invoke(TurnStart!);
            }
            else if (IsTurnUpdate)
            {
                turnUpdate?.Invoke(TurnUpdate!);
            }
            else if (IsTurnEagerEnd)
            {
                turnEagerEnd?.Invoke(TurnEagerEnd!);
            }
            else if (IsTurnResume)
            {
                turnResume?.Invoke(TurnResume!);
            }
            else if (IsTurnEnd)
            {
                turnEnd?.Invoke(TurnEnd!);
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
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected>? connected = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart>? turnStart = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate>? turnUpdate = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd>? turnEagerEnd = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume>? turnResume = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd>? turnEnd = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnected)
            {
                connected?.Invoke(Connected!);
            }
            else if (IsTurnStart)
            {
                turnStart?.Invoke(TurnStart!);
            }
            else if (IsTurnUpdate)
            {
                turnUpdate?.Invoke(TurnUpdate!);
            }
            else if (IsTurnEagerEnd)
            {
                turnEagerEnd?.Invoke(TurnEagerEnd!);
            }
            else if (IsTurnResume)
            {
                turnResume?.Invoke(TurnResume!);
            }
            else if (IsTurnEnd)
            {
                turnEnd?.Invoke(TurnEnd!);
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
                Connected,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected),
                TurnStart,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart),
                TurnUpdate,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate),
                TurnEagerEnd,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd),
                TurnResume,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume),
                TurnEnd,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd),
                Error,
                typeof(global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse),
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
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsConnected?>.Default.Equals(Connected, other.Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnStart?>.Default.Equals(TurnStart, other.TurnStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnUpdate?>.Default.Equals(TurnUpdate, other.TurnUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEagerEnd?>.Default.Equals(TurnEagerEnd, other.TurnEagerEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnResume?>.Default.Equals(TurnResume, other.TurnResume) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTTurnsTurnEnd?>.Default.Equals(TurnEnd, other.TurnEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToTextTurns.STTErrorResponse?>.Default.Equals(Error, other.Error)
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
