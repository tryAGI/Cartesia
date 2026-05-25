#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Events emitted by the server. Each event has a `type` field that discriminates between message variants. All emitted text is final — the model does not revise previous output. The `transcript` field is cumulative within a turn.
    /// </summary>
    public readonly partial struct STTTurnsWebSocketResponse : global::System.IEquatable<STTTurnsWebSocketResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// Fires once when the WebSocket connection is established. You do not need to wait for this event before sending audio.<br/>
        /// Example: {"type":"connected","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsConnected? Connected { get; init; }
#else
        public global::Cartesia.STTTurnsConnected? Connected { get; }
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
            out global::Cartesia.STTTurnsConnected? value)
        {
            value = Connected;
            return IsConnected;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsConnected PickConnected() => IsConnected
            ? Connected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connected' but the value was {ToString()}.");

        /// <summary>
        /// Marks the start of a user turn. Fires quickly after the user begins speaking. This event can be used to interrupt your agent to avoid talking over the user.<br/>
        /// Example: {"type":"turn.start","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsTurnStart? TurnStart { get; init; }
#else
        public global::Cartesia.STTTurnsTurnStart? TurnStart { get; }
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
            out global::Cartesia.STTTurnsTurnStart? value)
        {
            value = TurnStart;
            return IsTurnStart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsTurnStart PickTurnStart() => IsTurnStart
            ? TurnStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnStart' but the value was {ToString()}.");

        /// <summary>
        /// Fires repeatedly as the model transcribes the current user turn.<br/>
        /// Example: {"type":"turn.update","transcript":"Hey can you help","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsTurnUpdate? TurnUpdate { get; init; }
#else
        public global::Cartesia.STTTurnsTurnUpdate? TurnUpdate { get; }
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
            out global::Cartesia.STTTurnsTurnUpdate? value)
        {
            value = TurnUpdate;
            return IsTurnUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsTurnUpdate PickTurnUpdate() => IsTurnUpdate
            ? TurnUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnUpdate' but the value was {ToString()}.");

        /// <summary>
        /// [PREVIEW] Fires when the model predicts that the user might be done speaking.<br/>
        /// Example: {"type":"turn.eager_end","transcript":"Hey can you help me with something?","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsTurnEagerEnd? TurnEagerEnd { get; init; }
#else
        public global::Cartesia.STTTurnsTurnEagerEnd? TurnEagerEnd { get; }
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
            out global::Cartesia.STTTurnsTurnEagerEnd? value)
        {
            value = TurnEagerEnd;
            return IsTurnEagerEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsTurnEagerEnd PickTurnEagerEnd() => IsTurnEagerEnd
            ? TurnEagerEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnEagerEnd' but the value was {ToString()}.");

        /// <summary>
        /// [PREVIEW] Fires after `turn.eager_end` if the user turn has not actually ended.<br/>
        /// Example: {"type":"turn.resume","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsTurnResume? TurnResume { get; init; }
#else
        public global::Cartesia.STTTurnsTurnResume? TurnResume { get; }
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
            out global::Cartesia.STTTurnsTurnResume? value)
        {
            value = TurnResume;
            return IsTurnResume;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsTurnResume PickTurnResume() => IsTurnResume
            ? TurnResume!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnResume' but the value was {ToString()}.");

        /// <summary>
        /// Marks the end of a user turn.<br/>
        /// Example: {"type":"turn.end","transcript":"Hey can you help me with something?","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsTurnEnd? TurnEnd { get; init; }
#else
        public global::Cartesia.STTTurnsTurnEnd? TurnEnd { get; }
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
            out global::Cartesia.STTTurnsTurnEnd? value)
        {
            value = TurnEnd;
            return IsTurnEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsTurnEnd PickTurnEnd() => IsTurnEnd
            ? TurnEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnEnd' but the value was {ToString()}.");

        /// <summary>
        /// Error information for STT WebSocket connections.<br/>
        /// Example: {"type":"error","title":"Invalid model","message":"The model is not valid, make sure it is a valid model ID.","error_code":"model_not_found","doc_url":"https://docs.cartesia.ai/build-with-cartesia/stt-models/latest","status_code":400,"request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTErrorResponse? Error { get; init; }
#else
        public global::Cartesia.STTErrorResponse? Error { get; }
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
            out global::Cartesia.STTErrorResponse? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTErrorResponse PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTTurnsConnected value) => new STTTurnsWebSocketResponse((global::Cartesia.STTTurnsConnected?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsConnected?(STTTurnsWebSocketResponse @this) => @this.Connected;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTTurnsConnected? value)
        {
            Connected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromConnected(global::Cartesia.STTTurnsConnected? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnStart value) => new STTTurnsWebSocketResponse((global::Cartesia.STTTurnsTurnStart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsTurnStart?(STTTurnsWebSocketResponse @this) => @this.TurnStart;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnStart? value)
        {
            TurnStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromTurnStart(global::Cartesia.STTTurnsTurnStart? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnUpdate value) => new STTTurnsWebSocketResponse((global::Cartesia.STTTurnsTurnUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsTurnUpdate?(STTTurnsWebSocketResponse @this) => @this.TurnUpdate;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnUpdate? value)
        {
            TurnUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromTurnUpdate(global::Cartesia.STTTurnsTurnUpdate? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnEagerEnd value) => new STTTurnsWebSocketResponse((global::Cartesia.STTTurnsTurnEagerEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsTurnEagerEnd?(STTTurnsWebSocketResponse @this) => @this.TurnEagerEnd;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnEagerEnd? value)
        {
            TurnEagerEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromTurnEagerEnd(global::Cartesia.STTTurnsTurnEagerEnd? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnResume value) => new STTTurnsWebSocketResponse((global::Cartesia.STTTurnsTurnResume?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsTurnResume?(STTTurnsWebSocketResponse @this) => @this.TurnResume;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnResume? value)
        {
            TurnResume = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromTurnResume(global::Cartesia.STTTurnsTurnResume? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnEnd value) => new STTTurnsWebSocketResponse((global::Cartesia.STTTurnsTurnEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsTurnEnd?(STTTurnsWebSocketResponse @this) => @this.TurnEnd;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTTurnsTurnEnd? value)
        {
            TurnEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromTurnEnd(global::Cartesia.STTTurnsTurnEnd? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketResponse(global::Cartesia.STTErrorResponse value) => new STTTurnsWebSocketResponse((global::Cartesia.STTErrorResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTErrorResponse?(STTTurnsWebSocketResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(global::Cartesia.STTErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketResponse FromError(global::Cartesia.STTErrorResponse? value) => new STTTurnsWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketResponse(
            global::Cartesia.STTTurnsWebSocketResponseDiscriminatorType? type,
            global::Cartesia.STTTurnsConnected? connected,
            global::Cartesia.STTTurnsTurnStart? turnStart,
            global::Cartesia.STTTurnsTurnUpdate? turnUpdate,
            global::Cartesia.STTTurnsTurnEagerEnd? turnEagerEnd,
            global::Cartesia.STTTurnsTurnResume? turnResume,
            global::Cartesia.STTTurnsTurnEnd? turnEnd,
            global::Cartesia.STTErrorResponse? error
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
            global::System.Func<global::Cartesia.STTTurnsConnected, TResult>? connected = null,
            global::System.Func<global::Cartesia.STTTurnsTurnStart, TResult>? turnStart = null,
            global::System.Func<global::Cartesia.STTTurnsTurnUpdate, TResult>? turnUpdate = null,
            global::System.Func<global::Cartesia.STTTurnsTurnEagerEnd, TResult>? turnEagerEnd = null,
            global::System.Func<global::Cartesia.STTTurnsTurnResume, TResult>? turnResume = null,
            global::System.Func<global::Cartesia.STTTurnsTurnEnd, TResult>? turnEnd = null,
            global::System.Func<global::Cartesia.STTErrorResponse, TResult>? error = null,
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
            global::System.Action<global::Cartesia.STTTurnsConnected>? connected = null,

            global::System.Action<global::Cartesia.STTTurnsTurnStart>? turnStart = null,

            global::System.Action<global::Cartesia.STTTurnsTurnUpdate>? turnUpdate = null,

            global::System.Action<global::Cartesia.STTTurnsTurnEagerEnd>? turnEagerEnd = null,

            global::System.Action<global::Cartesia.STTTurnsTurnResume>? turnResume = null,

            global::System.Action<global::Cartesia.STTTurnsTurnEnd>? turnEnd = null,

            global::System.Action<global::Cartesia.STTErrorResponse>? error = null,
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
            global::System.Action<global::Cartesia.STTTurnsConnected>? connected = null,
            global::System.Action<global::Cartesia.STTTurnsTurnStart>? turnStart = null,
            global::System.Action<global::Cartesia.STTTurnsTurnUpdate>? turnUpdate = null,
            global::System.Action<global::Cartesia.STTTurnsTurnEagerEnd>? turnEagerEnd = null,
            global::System.Action<global::Cartesia.STTTurnsTurnResume>? turnResume = null,
            global::System.Action<global::Cartesia.STTTurnsTurnEnd>? turnEnd = null,
            global::System.Action<global::Cartesia.STTErrorResponse>? error = null,
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
                typeof(global::Cartesia.STTTurnsConnected),
                TurnStart,
                typeof(global::Cartesia.STTTurnsTurnStart),
                TurnUpdate,
                typeof(global::Cartesia.STTTurnsTurnUpdate),
                TurnEagerEnd,
                typeof(global::Cartesia.STTTurnsTurnEagerEnd),
                TurnResume,
                typeof(global::Cartesia.STTTurnsTurnResume),
                TurnEnd,
                typeof(global::Cartesia.STTTurnsTurnEnd),
                Error,
                typeof(global::Cartesia.STTErrorResponse),
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
        public bool Equals(STTTurnsWebSocketResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsConnected?>.Default.Equals(Connected, other.Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsTurnStart?>.Default.Equals(TurnStart, other.TurnStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsTurnUpdate?>.Default.Equals(TurnUpdate, other.TurnUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsTurnEagerEnd?>.Default.Equals(TurnEagerEnd, other.TurnEagerEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsTurnResume?>.Default.Equals(TurnResume, other.TurnResume) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsTurnEnd?>.Default.Equals(TurnEnd, other.TurnEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTErrorResponse?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(STTTurnsWebSocketResponse obj1, STTTurnsWebSocketResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<STTTurnsWebSocketResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(STTTurnsWebSocketResponse obj1, STTTurnsWebSocketResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTTurnsWebSocketResponse o && Equals(o);
        }
    }
}
