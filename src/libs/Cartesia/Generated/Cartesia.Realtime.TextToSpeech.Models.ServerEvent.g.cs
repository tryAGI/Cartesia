#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Audio data chunk
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.TextToSpeech.ChunkResponse? Chunk { get; init; }
#else
        public global::Cartesia.Realtime.TextToSpeech.ChunkResponse? Chunk { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chunk))]
#endif
        public bool IsChunk => Chunk != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.TextToSpeech.ChunkResponse? value)
        {
            value = Chunk;
            return IsChunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.ChunkResponse PickChunk() => IsChunk
            ? Chunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chunk' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledgment that flush command was received. See [Context Flushing](/use-the-api/tts-websocket/context-flushing-and-flush-i-ds) for details.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? FlushDone { get; init; }
#else
        public global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? FlushDone { get; }
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
            out global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? value)
        {
            value = FlushDone;
            return IsFlushDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse PickFlushDone() => IsFlushDone
            ? FlushDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FlushDone' but the value was {ToString()}.");

        /// <summary>
        /// Generation completion signal
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? Done { get; init; }
#else
        public global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? Done { get; }
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
            out global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? value)
        {
            value = Done;
            return IsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse PickDone() => IsDone
            ? Done!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Done' but the value was {ToString()}.");

        /// <summary>
        /// Word-level timing information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? Timestamps { get; init; }
#else
        public global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? Timestamps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Timestamps))]
#endif
        public bool IsTimestamps => Timestamps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimestamps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? value)
        {
            value = Timestamps;
            return IsTimestamps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TimestampsResponse PickTimestamps() => IsTimestamps
            ? Timestamps!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Timestamps' but the value was {ToString()}.");

        /// <summary>
        /// Phoneme-level timing information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? PhonemeTimestamps { get; init; }
#else
        public global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? PhonemeTimestamps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhonemeTimestamps))]
#endif
        public bool IsPhonemeTimestamps => PhonemeTimestamps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPhonemeTimestamps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? value)
        {
            value = PhonemeTimestamps;
            return IsPhonemeTimestamps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse PickPhonemeTimestamps() => IsPhonemeTimestamps
            ? PhonemeTimestamps!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PhonemeTimestamps' but the value was {ToString()}.");

        /// <summary>
        /// Error information for TTS WebSocket connections.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? Error { get; init; }
#else
        public global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? Error { get; }
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
            out global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.TextToSpeech.ChunkResponse value) => new ServerEvent((global::Cartesia.Realtime.TextToSpeech.ChunkResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.TextToSpeech.ChunkResponse?(ServerEvent @this) => @this.Chunk;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.TextToSpeech.ChunkResponse? value)
        {
            Chunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromChunk(global::Cartesia.Realtime.TextToSpeech.ChunkResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse value) => new ServerEvent((global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse?(ServerEvent @this) => @this.FlushDone;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? value)
        {
            FlushDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromFlushDone(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse value) => new ServerEvent((global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse?(ServerEvent @this) => @this.Done;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? value)
        {
            Done = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromDone(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse value) => new ServerEvent((global::Cartesia.Realtime.TextToSpeech.TimestampsResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.TextToSpeech.TimestampsResponse?(ServerEvent @this) => @this.Timestamps;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? value)
        {
            Timestamps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromTimestamps(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse value) => new ServerEvent((global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse?(ServerEvent @this) => @this.PhonemeTimestamps;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? value)
        {
            PhonemeTimestamps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromPhonemeTimestamps(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse value) => new ServerEvent((global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse?(ServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromError(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(
            global::Cartesia.Realtime.TextToSpeech.ServerEventDiscriminatorType? type,
            global::Cartesia.Realtime.TextToSpeech.ChunkResponse? chunk,
            global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse? flushDone,
            global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse? done,
            global::Cartesia.Realtime.TextToSpeech.TimestampsResponse? timestamps,
            global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse? phonemeTimestamps,
            global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse? error
            )
        {
            Type = type;

            Chunk = chunk;
            FlushDone = flushDone;
            Done = done;
            Timestamps = timestamps;
            PhonemeTimestamps = phonemeTimestamps;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            PhonemeTimestamps as object ??
            Timestamps as object ??
            Done as object ??
            FlushDone as object ??
            Chunk as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Chunk?.ToString() ??
            FlushDone?.ToString() ??
            Done?.ToString() ??
            Timestamps?.ToString() ??
            PhonemeTimestamps?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && !IsPhonemeTimestamps && !IsError || !IsChunk && IsFlushDone && !IsDone && !IsTimestamps && !IsPhonemeTimestamps && !IsError || !IsChunk && !IsFlushDone && IsDone && !IsTimestamps && !IsPhonemeTimestamps && !IsError || !IsChunk && !IsFlushDone && !IsDone && IsTimestamps && !IsPhonemeTimestamps && !IsError || !IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && IsPhonemeTimestamps && !IsError || !IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && !IsPhonemeTimestamps && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.Realtime.TextToSpeech.ChunkResponse, TResult>? chunk = null,
            global::System.Func<global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse, TResult>? flushDone = null,
            global::System.Func<global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse, TResult>? done = null,
            global::System.Func<global::Cartesia.Realtime.TextToSpeech.TimestampsResponse, TResult>? timestamps = null,
            global::System.Func<global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse, TResult>? phonemeTimestamps = null,
            global::System.Func<global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChunk && chunk != null)
            {
                return chunk(Chunk!);
            }
            else if (IsFlushDone && flushDone != null)
            {
                return flushDone(FlushDone!);
            }
            else if (IsDone && done != null)
            {
                return done(Done!);
            }
            else if (IsTimestamps && timestamps != null)
            {
                return timestamps(Timestamps!);
            }
            else if (IsPhonemeTimestamps && phonemeTimestamps != null)
            {
                return phonemeTimestamps(PhonemeTimestamps!);
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
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.ChunkResponse>? chunk = null,

            global::System.Action<global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse>? flushDone = null,

            global::System.Action<global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse>? done = null,

            global::System.Action<global::Cartesia.Realtime.TextToSpeech.TimestampsResponse>? timestamps = null,

            global::System.Action<global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse>? phonemeTimestamps = null,

            global::System.Action<global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChunk)
            {
                chunk?.Invoke(Chunk!);
            }
            else if (IsFlushDone)
            {
                flushDone?.Invoke(FlushDone!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
            else if (IsTimestamps)
            {
                timestamps?.Invoke(Timestamps!);
            }
            else if (IsPhonemeTimestamps)
            {
                phonemeTimestamps?.Invoke(PhonemeTimestamps!);
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
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.ChunkResponse>? chunk = null,
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse>? flushDone = null,
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse>? done = null,
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.TimestampsResponse>? timestamps = null,
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse>? phonemeTimestamps = null,
            global::System.Action<global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChunk)
            {
                chunk?.Invoke(Chunk!);
            }
            else if (IsFlushDone)
            {
                flushDone?.Invoke(FlushDone!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
            else if (IsTimestamps)
            {
                timestamps?.Invoke(Timestamps!);
            }
            else if (IsPhonemeTimestamps)
            {
                phonemeTimestamps?.Invoke(PhonemeTimestamps!);
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
                Chunk,
                typeof(global::Cartesia.Realtime.TextToSpeech.ChunkResponse),
                FlushDone,
                typeof(global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse),
                Done,
                typeof(global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse),
                Timestamps,
                typeof(global::Cartesia.Realtime.TextToSpeech.TimestampsResponse),
                PhonemeTimestamps,
                typeof(global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse),
                Error,
                typeof(global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse),
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
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.TextToSpeech.ChunkResponse?>.Default.Equals(Chunk, other.Chunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.TextToSpeech.FlushDoneResponse?>.Default.Equals(FlushDone, other.FlushDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.TextToSpeech.GenerationDoneResponse?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.TextToSpeech.TimestampsResponse?>.Default.Equals(Timestamps, other.Timestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.TextToSpeech.PhonemeTimestampsResponse?>.Default.Equals(PhonemeTimestamps, other.PhonemeTimestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.Realtime.TextToSpeech.TTSErrorResponse?>.Default.Equals(Error, other.Error)
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
