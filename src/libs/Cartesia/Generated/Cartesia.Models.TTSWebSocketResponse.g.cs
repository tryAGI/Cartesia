#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TTSWebSocketResponse : global::System.IEquatable<TTSWebSocketResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSWebSocketResponseVariant1? Chunk { get; init; }
#else
        public global::Cartesia.TTSWebSocketResponseVariant1? Chunk { get; }
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
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSWebSocketResponseVariant2? FlushDone { get; init; }
#else
        public global::Cartesia.TTSWebSocketResponseVariant2? FlushDone { get; }
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
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSWebSocketResponseVariant3? Done { get; init; }
#else
        public global::Cartesia.TTSWebSocketResponseVariant3? Done { get; }
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
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSWebSocketResponseVariant4? Timestamps { get; init; }
#else
        public global::Cartesia.TTSWebSocketResponseVariant4? Timestamps { get; }
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
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSWebSocketResponseVariant5? Error { get; init; }
#else
        public global::Cartesia.TTSWebSocketResponseVariant5? Error { get; }
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
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSWebSocketResponseVariant6? PhonemeTimestamps { get; init; }
#else
        public global::Cartesia.TTSWebSocketResponseVariant6? PhonemeTimestamps { get; }
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
        public static implicit operator TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant1 value) => new TTSWebSocketResponse((global::Cartesia.TTSWebSocketResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSWebSocketResponseVariant1?(TTSWebSocketResponse @this) => @this.Chunk;

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant1? value)
        {
            Chunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant2 value) => new TTSWebSocketResponse((global::Cartesia.TTSWebSocketResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSWebSocketResponseVariant2?(TTSWebSocketResponse @this) => @this.FlushDone;

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant2? value)
        {
            FlushDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant3 value) => new TTSWebSocketResponse((global::Cartesia.TTSWebSocketResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSWebSocketResponseVariant3?(TTSWebSocketResponse @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant3? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant4 value) => new TTSWebSocketResponse((global::Cartesia.TTSWebSocketResponseVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSWebSocketResponseVariant4?(TTSWebSocketResponse @this) => @this.Timestamps;

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant4? value)
        {
            Timestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant5 value) => new TTSWebSocketResponse((global::Cartesia.TTSWebSocketResponseVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSWebSocketResponseVariant5?(TTSWebSocketResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant5? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant6 value) => new TTSWebSocketResponse((global::Cartesia.TTSWebSocketResponseVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSWebSocketResponseVariant6?(TTSWebSocketResponse @this) => @this.PhonemeTimestamps;

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(global::Cartesia.TTSWebSocketResponseVariant6? value)
        {
            PhonemeTimestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TTSWebSocketResponse(
            global::Cartesia.TTSWebSocketResponseVariant1? chunk,
            global::Cartesia.TTSWebSocketResponseVariant2? flushDone,
            global::Cartesia.TTSWebSocketResponseVariant3? done,
            global::Cartesia.TTSWebSocketResponseVariant4? timestamps,
            global::Cartesia.TTSWebSocketResponseVariant5? error,
            global::Cartesia.TTSWebSocketResponseVariant6? phonemeTimestamps
            )
        {
            Chunk = chunk;
            FlushDone = flushDone;
            Done = done;
            Timestamps = timestamps;
            Error = error;
            PhonemeTimestamps = phonemeTimestamps;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PhonemeTimestamps as object ??
            Error as object ??
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
            Error?.ToString() ??
            PhonemeTimestamps?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && IsFlushDone && !IsDone && !IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && IsDone && !IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && !IsDone && IsTimestamps && !IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && IsError && !IsPhonemeTimestamps || !IsChunk && !IsFlushDone && !IsDone && !IsTimestamps && !IsError && IsPhonemeTimestamps;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.TTSWebSocketResponseVariant1?, TResult>? chunk = null,
            global::System.Func<global::Cartesia.TTSWebSocketResponseVariant2?, TResult>? flushDone = null,
            global::System.Func<global::Cartesia.TTSWebSocketResponseVariant3?, TResult>? done = null,
            global::System.Func<global::Cartesia.TTSWebSocketResponseVariant4?, TResult>? timestamps = null,
            global::System.Func<global::Cartesia.TTSWebSocketResponseVariant5?, TResult>? error = null,
            global::System.Func<global::Cartesia.TTSWebSocketResponseVariant6?, TResult>? phonemeTimestamps = null,
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
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsPhonemeTimestamps && phonemeTimestamps != null)
            {
                return phonemeTimestamps(PhonemeTimestamps!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.TTSWebSocketResponseVariant1?>? chunk = null,
            global::System.Action<global::Cartesia.TTSWebSocketResponseVariant2?>? flushDone = null,
            global::System.Action<global::Cartesia.TTSWebSocketResponseVariant3?>? done = null,
            global::System.Action<global::Cartesia.TTSWebSocketResponseVariant4?>? timestamps = null,
            global::System.Action<global::Cartesia.TTSWebSocketResponseVariant5?>? error = null,
            global::System.Action<global::Cartesia.TTSWebSocketResponseVariant6?>? phonemeTimestamps = null,
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
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsPhonemeTimestamps)
            {
                phonemeTimestamps?.Invoke(PhonemeTimestamps!);
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
                typeof(global::Cartesia.TTSWebSocketResponseVariant1),
                FlushDone,
                typeof(global::Cartesia.TTSWebSocketResponseVariant2),
                Done,
                typeof(global::Cartesia.TTSWebSocketResponseVariant3),
                Timestamps,
                typeof(global::Cartesia.TTSWebSocketResponseVariant4),
                Error,
                typeof(global::Cartesia.TTSWebSocketResponseVariant5),
                PhonemeTimestamps,
                typeof(global::Cartesia.TTSWebSocketResponseVariant6),
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
        public bool Equals(TTSWebSocketResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSWebSocketResponseVariant1?>.Default.Equals(Chunk, other.Chunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSWebSocketResponseVariant2?>.Default.Equals(FlushDone, other.FlushDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSWebSocketResponseVariant3?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSWebSocketResponseVariant4?>.Default.Equals(Timestamps, other.Timestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSWebSocketResponseVariant5?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSWebSocketResponseVariant6?>.Default.Equals(PhonemeTimestamps, other.PhonemeTimestamps) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TTSWebSocketResponse obj1, TTSWebSocketResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TTSWebSocketResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TTSWebSocketResponse obj1, TTSWebSocketResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TTSWebSocketResponse o && Equals(o);
        }
    }
}
