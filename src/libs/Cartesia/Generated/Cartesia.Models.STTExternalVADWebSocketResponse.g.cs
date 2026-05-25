#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Events emitted by the server. Each event has a `type` field that discriminates between message variants.
    /// </summary>
    public readonly partial struct STTExternalVADWebSocketResponse : global::System.IEquatable<STTExternalVADWebSocketResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTExternalVADWebSocketResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// A transcript chunk.<br/>
        /// Example: {"type":"transcript","is_final":true,"request_id":"b67e1c5d-2f4c-4c3d-9f82-96eb4d2f12a8","text":"How are you doing today?","duration":2.5,"language":"en","words":[{"word":"How","start":0,"end":0.12},{"word":"are","start":0.15,"end":0.25},{"word":"you","start":0.28,"end":0.35},{"word":"doing","start":0.38,"end":0.55},{"word":"today?","start":0.58,"end":0.78}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTExternalVADTranscriptResponse? Transcript { get; init; }
#else
        public global::Cartesia.STTExternalVADTranscriptResponse? Transcript { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transcript))]
#endif
        public bool IsTranscript => Transcript != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscript(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.STTExternalVADTranscriptResponse? value)
        {
            value = Transcript;
            return IsTranscript;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTExternalVADTranscriptResponse PickTranscript() => IsTranscript
            ? Transcript!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transcript' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledgment that buffered audio has been processed in response to a `finalize` command.<br/>
        /// Example: {"type":"flush_done","request_id":"b67e1c5d-2f4c-4c3d-9f82-96eb4d2f12a8"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTExternalVADFlushDoneResponse? FlushDone { get; init; }
#else
        public global::Cartesia.STTExternalVADFlushDoneResponse? FlushDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlushDone))]
#endif
        public bool IsFlushDone => FlushDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFlushDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.STTExternalVADFlushDoneResponse? value)
        {
            value = FlushDone;
            return IsFlushDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTExternalVADFlushDoneResponse PickFlushDone() => IsFlushDone
            ? FlushDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FlushDone' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledgment for the `close` command, sent after all buffered audio has been processed and before the connection closes.<br/>
        /// Example: {"type":"done","request_id":"b67e1c5d-2f4c-4c3d-9f82-96eb4d2f12a8"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTExternalVADDoneResponse? Done { get; init; }
#else
        public global::Cartesia.STTExternalVADDoneResponse? Done { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.STTExternalVADDoneResponse? value)
        {
            value = Done;
            return IsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTExternalVADDoneResponse PickDone() => IsDone
            ? Done!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Done' but the value was {ToString()}.");

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
        public static implicit operator STTExternalVADWebSocketResponse(global::Cartesia.STTExternalVADTranscriptResponse value) => new STTExternalVADWebSocketResponse((global::Cartesia.STTExternalVADTranscriptResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTExternalVADTranscriptResponse?(STTExternalVADWebSocketResponse @this) => @this.Transcript;

        /// <summary>
        /// 
        /// </summary>
        public STTExternalVADWebSocketResponse(global::Cartesia.STTExternalVADTranscriptResponse? value)
        {
            Transcript = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTExternalVADWebSocketResponse FromTranscript(global::Cartesia.STTExternalVADTranscriptResponse? value) => new STTExternalVADWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTExternalVADWebSocketResponse(global::Cartesia.STTExternalVADFlushDoneResponse value) => new STTExternalVADWebSocketResponse((global::Cartesia.STTExternalVADFlushDoneResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTExternalVADFlushDoneResponse?(STTExternalVADWebSocketResponse @this) => @this.FlushDone;

        /// <summary>
        /// 
        /// </summary>
        public STTExternalVADWebSocketResponse(global::Cartesia.STTExternalVADFlushDoneResponse? value)
        {
            FlushDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTExternalVADWebSocketResponse FromFlushDone(global::Cartesia.STTExternalVADFlushDoneResponse? value) => new STTExternalVADWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTExternalVADWebSocketResponse(global::Cartesia.STTExternalVADDoneResponse value) => new STTExternalVADWebSocketResponse((global::Cartesia.STTExternalVADDoneResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTExternalVADDoneResponse?(STTExternalVADWebSocketResponse @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public STTExternalVADWebSocketResponse(global::Cartesia.STTExternalVADDoneResponse? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTExternalVADWebSocketResponse FromDone(global::Cartesia.STTExternalVADDoneResponse? value) => new STTExternalVADWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTExternalVADWebSocketResponse(global::Cartesia.STTErrorResponse value) => new STTExternalVADWebSocketResponse((global::Cartesia.STTErrorResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTErrorResponse?(STTExternalVADWebSocketResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public STTExternalVADWebSocketResponse(global::Cartesia.STTErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTExternalVADWebSocketResponse FromError(global::Cartesia.STTErrorResponse? value) => new STTExternalVADWebSocketResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public STTExternalVADWebSocketResponse(
            global::Cartesia.STTExternalVADWebSocketResponseDiscriminatorType? type,
            global::Cartesia.STTExternalVADTranscriptResponse? transcript,
            global::Cartesia.STTExternalVADFlushDoneResponse? flushDone,
            global::Cartesia.STTExternalVADDoneResponse? done,
            global::Cartesia.STTErrorResponse? error
            )
        {
            Type = type;

            Transcript = transcript;
            FlushDone = flushDone;
            Done = done;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Done as object ??
            FlushDone as object ??
            Transcript as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Transcript?.ToString() ??
            FlushDone?.ToString() ??
            Done?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscript && !IsFlushDone && !IsDone && !IsError || !IsTranscript && IsFlushDone && !IsDone && !IsError || !IsTranscript && !IsFlushDone && IsDone && !IsError || !IsTranscript && !IsFlushDone && !IsDone && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.STTExternalVADTranscriptResponse, TResult>? transcript = null,
            global::System.Func<global::Cartesia.STTExternalVADFlushDoneResponse, TResult>? flushDone = null,
            global::System.Func<global::Cartesia.STTExternalVADDoneResponse, TResult>? done = null,
            global::System.Func<global::Cartesia.STTErrorResponse, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscript && transcript != null)
            {
                return transcript(Transcript!);
            }
            else if (IsFlushDone && flushDone != null)
            {
                return flushDone(FlushDone!);
            }
            else if (IsDone && done != null)
            {
                return done(Done!);
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
            global::System.Action<global::Cartesia.STTExternalVADTranscriptResponse>? transcript = null,

            global::System.Action<global::Cartesia.STTExternalVADFlushDoneResponse>? flushDone = null,

            global::System.Action<global::Cartesia.STTExternalVADDoneResponse>? done = null,

            global::System.Action<global::Cartesia.STTErrorResponse>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscript)
            {
                transcript?.Invoke(Transcript!);
            }
            else if (IsFlushDone)
            {
                flushDone?.Invoke(FlushDone!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
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
            global::System.Action<global::Cartesia.STTExternalVADTranscriptResponse>? transcript = null,
            global::System.Action<global::Cartesia.STTExternalVADFlushDoneResponse>? flushDone = null,
            global::System.Action<global::Cartesia.STTExternalVADDoneResponse>? done = null,
            global::System.Action<global::Cartesia.STTErrorResponse>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscript)
            {
                transcript?.Invoke(Transcript!);
            }
            else if (IsFlushDone)
            {
                flushDone?.Invoke(FlushDone!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
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
                Transcript,
                typeof(global::Cartesia.STTExternalVADTranscriptResponse),
                FlushDone,
                typeof(global::Cartesia.STTExternalVADFlushDoneResponse),
                Done,
                typeof(global::Cartesia.STTExternalVADDoneResponse),
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
        public bool Equals(STTExternalVADWebSocketResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTExternalVADTranscriptResponse?>.Default.Equals(Transcript, other.Transcript) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTExternalVADFlushDoneResponse?>.Default.Equals(FlushDone, other.FlushDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTExternalVADDoneResponse?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTErrorResponse?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(STTExternalVADWebSocketResponse obj1, STTExternalVADWebSocketResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<STTExternalVADWebSocketResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(STTExternalVADWebSocketResponse obj1, STTExternalVADWebSocketResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTExternalVADWebSocketResponse o && Equals(o);
        }
    }
}
