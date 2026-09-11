#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia.Realtime.SpeechToText
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Transcript chunks.<br/>
        /// You should send the `finalize` command after the user is done speaking to make the API emit these transcript chunks;<br/>
        /// although, the API may send transcript chunks even before you send the `finalize` command.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? Transcript { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? Transcript { get; }
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
            out global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? value)
        {
            value = Transcript;
            return IsTranscript;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse PickTranscript() => IsTranscript
            ? Transcript!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transcript' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledgment for the `finalize` command
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? FlushDone { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? FlushDone { get; }
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
            out global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? value)
        {
            value = FlushDone;
            return IsFlushDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse PickFlushDone() => IsFlushDone
            ? FlushDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FlushDone' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledgment for the `close` command
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponse? Done { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponse? Done { get; }
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
            out global::Cartesia.Realtime.SpeechToText.STTDoneResponse? value)
        {
            value = Done;
            return IsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTDoneResponse PickDone() => IsDone
            ? Done!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Done' but the value was {ToString()}.");

        /// <summary>
        /// Error information for STT WebSocket connections.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponse? Error { get; init; }
#else
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponse? Error { get; }
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
            out global::Cartesia.Realtime.SpeechToText.STTErrorResponse? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.SpeechToText.STTErrorResponse PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse value) => new ServerEvent((global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse?(ServerEvent @this) => @this.Transcript;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? value)
        {
            Transcript = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTranscript(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse value) => new ServerEvent((global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse?(ServerEvent @this) => @this.FlushDone;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? value)
        {
            FlushDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromFlushDone(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToText.STTDoneResponse value) => new ServerEvent((global::Cartesia.Realtime.SpeechToText.STTDoneResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToText.STTDoneResponse?(ServerEvent @this) => @this.Done;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToText.STTDoneResponse? value)
        {
            Done = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromDone(global::Cartesia.Realtime.SpeechToText.STTDoneResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.SpeechToText.STTErrorResponse value) => new ServerEvent((global::Cartesia.Realtime.SpeechToText.STTErrorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.SpeechToText.STTErrorResponse?(ServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.SpeechToText.STTErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromError(global::Cartesia.Realtime.SpeechToText.STTErrorResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(
            global::Cartesia.Realtime.SpeechToText.ServerEventDiscriminatorType? type,
            global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse? transcript,
            global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse? flushDone,
            global::Cartesia.Realtime.SpeechToText.STTDoneResponse? done,
            global::Cartesia.Realtime.SpeechToText.STTErrorResponse? error
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
            global::System.Func<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse, TResult>? transcript = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse, TResult>? flushDone = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToText.STTDoneResponse, TResult>? done = null,
            global::System.Func<global::Cartesia.Realtime.SpeechToText.STTErrorResponse, TResult>? error = null,
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
            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse>? transcript = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse>? flushDone = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTDoneResponse>? done = null,

            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTErrorResponse>? error = null,
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
            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse>? transcript = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse>? flushDone = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTDoneResponse>? done = null,
            global::System.Action<global::Cartesia.Realtime.SpeechToText.STTErrorResponse>? error = null,
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
                typeof(global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse),
                FlushDone,
                typeof(global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse),
                Done,
                typeof(global::Cartesia.Realtime.SpeechToText.STTDoneResponse),
                Error,
                typeof(global::Cartesia.Realtime.SpeechToText.STTErrorResponse),
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
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToText.STTTranscriptResponse?>.Default.Equals(Transcript, other.Transcript) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToText.STTFlushDoneResponse?>.Default.Equals(FlushDone, other.FlushDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToText.STTDoneResponse?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.SpeechToText.STTErrorResponse?>.Default.Equals(Error, other.Error)
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
