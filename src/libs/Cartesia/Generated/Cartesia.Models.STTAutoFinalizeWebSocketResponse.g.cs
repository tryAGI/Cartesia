#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Events emitted by the server. Each event has a `type` field that discriminates between message variants. All emitted text is final — the model does not revise previous output. The `transcript` field is cumulative within a turn.
    /// </summary>
    public readonly partial struct STTAutoFinalizeWebSocketResponse : global::System.IEquatable<STTAutoFinalizeWebSocketResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// Fires once when the WebSocket connection is established. You do not need to wait for this event before sending audio.<br/>
        /// Example: {"type":"connected","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeConnected? Connected { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeConnected? Connected { get; }
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
            out global::Cartesia.STTAutoFinalizeConnected? value)
        {
            value = Connected;
            return IsConnected;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeConnected PickConnected() => IsConnected
            ? Connected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connected' but the value was {ToString()}.");

        /// <summary>
        /// Marks the start of a user turn. Fires quickly after the user begins speaking. This event can be used to interrupt your agent to avoid talking over the user.<br/>
        /// Example: {"type":"turn.start","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeTurnStart? TurnStart { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeTurnStart? TurnStart { get; }
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
            out global::Cartesia.STTAutoFinalizeTurnStart? value)
        {
            value = TurnStart;
            return IsTurnStart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnStart PickTurnStart() => IsTurnStart
            ? TurnStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnStart' but the value was {ToString()}.");

        /// <summary>
        /// Fires repeatedly as the model transcribes the current user turn.<br/>
        /// Example: {"type":"turn.update","transcript":"Hey can you help","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeTurnUpdate? TurnUpdate { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeTurnUpdate? TurnUpdate { get; }
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
            out global::Cartesia.STTAutoFinalizeTurnUpdate? value)
        {
            value = TurnUpdate;
            return IsTurnUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnUpdate PickTurnUpdate() => IsTurnUpdate
            ? TurnUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnUpdate' but the value was {ToString()}.");

        /// <summary>
        /// [PREVIEW] Fires when the model predicts that the user might be done speaking.<br/>
        /// Example: {"type":"turn.eager_end","transcript":"Hey can you help me with something?","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? TurnEagerEnd { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd? TurnEagerEnd { get; }
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
            out global::Cartesia.STTAutoFinalizeTurnEagerEnd? value)
        {
            value = TurnEagerEnd;
            return IsTurnEagerEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEagerEnd PickTurnEagerEnd() => IsTurnEagerEnd
            ? TurnEagerEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnEagerEnd' but the value was {ToString()}.");

        /// <summary>
        /// [PREVIEW] Fires after `turn.eager_end` if the user turn has not actually ended.<br/>
        /// Example: {"type":"turn.resume","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeTurnResume? TurnResume { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeTurnResume? TurnResume { get; }
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
            out global::Cartesia.STTAutoFinalizeTurnResume? value)
        {
            value = TurnResume;
            return IsTurnResume;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnResume PickTurnResume() => IsTurnResume
            ? TurnResume!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnResume' but the value was {ToString()}.");

        /// <summary>
        /// Marks the end of a user turn.<br/>
        /// Example: {"type":"turn.end","transcript":"Hey can you help me with something?","request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeTurnEnd? TurnEnd { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeTurnEnd? TurnEnd { get; }
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
            out global::Cartesia.STTAutoFinalizeTurnEnd? value)
        {
            value = TurnEnd;
            return IsTurnEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeTurnEnd PickTurnEnd() => IsTurnEnd
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
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeConnected value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTAutoFinalizeConnected?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeConnected?(STTAutoFinalizeWebSocketResponse @this) => @this.Connected;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeConnected? value)
        {
            Connected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromConnected(global::Cartesia.STTAutoFinalizeConnected? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnStart value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTAutoFinalizeTurnStart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeTurnStart?(STTAutoFinalizeWebSocketResponse @this) => @this.TurnStart;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnStart? value)
        {
            TurnStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromTurnStart(global::Cartesia.STTAutoFinalizeTurnStart? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnUpdate value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTAutoFinalizeTurnUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeTurnUpdate?(STTAutoFinalizeWebSocketResponse @this) => @this.TurnUpdate;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnUpdate? value)
        {
            TurnUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromTurnUpdate(global::Cartesia.STTAutoFinalizeTurnUpdate? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnEagerEnd value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTAutoFinalizeTurnEagerEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeTurnEagerEnd?(STTAutoFinalizeWebSocketResponse @this) => @this.TurnEagerEnd;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnEagerEnd? value)
        {
            TurnEagerEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromTurnEagerEnd(global::Cartesia.STTAutoFinalizeTurnEagerEnd? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnResume value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTAutoFinalizeTurnResume?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeTurnResume?(STTAutoFinalizeWebSocketResponse @this) => @this.TurnResume;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnResume? value)
        {
            TurnResume = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromTurnResume(global::Cartesia.STTAutoFinalizeTurnResume? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnEnd value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTAutoFinalizeTurnEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeTurnEnd?(STTAutoFinalizeWebSocketResponse @this) => @this.TurnEnd;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTAutoFinalizeTurnEnd? value)
        {
            TurnEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromTurnEnd(global::Cartesia.STTAutoFinalizeTurnEnd? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketResponse(global::Cartesia.STTErrorResponse value) => new STTAutoFinalizeWebSocketResponse((global::Cartesia.STTErrorResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTErrorResponse?(STTAutoFinalizeWebSocketResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(global::Cartesia.STTErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketResponse FromError(global::Cartesia.STTErrorResponse? value) => new STTAutoFinalizeWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketResponse(
            global::Cartesia.STTAutoFinalizeWebSocketResponseDiscriminatorType? type,
            global::Cartesia.STTAutoFinalizeConnected? connected,
            global::Cartesia.STTAutoFinalizeTurnStart? turnStart,
            global::Cartesia.STTAutoFinalizeTurnUpdate? turnUpdate,
            global::Cartesia.STTAutoFinalizeTurnEagerEnd? turnEagerEnd,
            global::Cartesia.STTAutoFinalizeTurnResume? turnResume,
            global::Cartesia.STTAutoFinalizeTurnEnd? turnEnd,
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
            global::System.Func<global::Cartesia.STTAutoFinalizeConnected, TResult>? connected = null,
            global::System.Func<global::Cartesia.STTAutoFinalizeTurnStart, TResult>? turnStart = null,
            global::System.Func<global::Cartesia.STTAutoFinalizeTurnUpdate, TResult>? turnUpdate = null,
            global::System.Func<global::Cartesia.STTAutoFinalizeTurnEagerEnd, TResult>? turnEagerEnd = null,
            global::System.Func<global::Cartesia.STTAutoFinalizeTurnResume, TResult>? turnResume = null,
            global::System.Func<global::Cartesia.STTAutoFinalizeTurnEnd, TResult>? turnEnd = null,
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
            global::System.Action<global::Cartesia.STTAutoFinalizeConnected>? connected = null,

            global::System.Action<global::Cartesia.STTAutoFinalizeTurnStart>? turnStart = null,

            global::System.Action<global::Cartesia.STTAutoFinalizeTurnUpdate>? turnUpdate = null,

            global::System.Action<global::Cartesia.STTAutoFinalizeTurnEagerEnd>? turnEagerEnd = null,

            global::System.Action<global::Cartesia.STTAutoFinalizeTurnResume>? turnResume = null,

            global::System.Action<global::Cartesia.STTAutoFinalizeTurnEnd>? turnEnd = null,

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
            global::System.Action<global::Cartesia.STTAutoFinalizeConnected>? connected = null,
            global::System.Action<global::Cartesia.STTAutoFinalizeTurnStart>? turnStart = null,
            global::System.Action<global::Cartesia.STTAutoFinalizeTurnUpdate>? turnUpdate = null,
            global::System.Action<global::Cartesia.STTAutoFinalizeTurnEagerEnd>? turnEagerEnd = null,
            global::System.Action<global::Cartesia.STTAutoFinalizeTurnResume>? turnResume = null,
            global::System.Action<global::Cartesia.STTAutoFinalizeTurnEnd>? turnEnd = null,
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
                typeof(global::Cartesia.STTAutoFinalizeConnected),
                TurnStart,
                typeof(global::Cartesia.STTAutoFinalizeTurnStart),
                TurnUpdate,
                typeof(global::Cartesia.STTAutoFinalizeTurnUpdate),
                TurnEagerEnd,
                typeof(global::Cartesia.STTAutoFinalizeTurnEagerEnd),
                TurnResume,
                typeof(global::Cartesia.STTAutoFinalizeTurnResume),
                TurnEnd,
                typeof(global::Cartesia.STTAutoFinalizeTurnEnd),
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
        public bool Equals(STTAutoFinalizeWebSocketResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeConnected?>.Default.Equals(Connected, other.Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeTurnStart?>.Default.Equals(TurnStart, other.TurnStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeTurnUpdate?>.Default.Equals(TurnUpdate, other.TurnUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeTurnEagerEnd?>.Default.Equals(TurnEagerEnd, other.TurnEagerEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeTurnResume?>.Default.Equals(TurnResume, other.TurnResume) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeTurnEnd?>.Default.Equals(TurnEnd, other.TurnEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTErrorResponse?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(STTAutoFinalizeWebSocketResponse obj1, STTAutoFinalizeWebSocketResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<STTAutoFinalizeWebSocketResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(STTAutoFinalizeWebSocketResponse obj1, STTAutoFinalizeWebSocketResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTAutoFinalizeWebSocketResponse o && Equals(o);
        }
    }
}
