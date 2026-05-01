#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An event emitted by the TTS SSE stream.
    /// </summary>
    public readonly partial struct TTSSSEEvent : global::System.IEquatable<TTSSSEEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.TTSSSEEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Audio data chunk.<br/>
        /// Example: {"type":"chunk","done":false,"status_code":206,"step_time":123,"context_id":"50dc3b5e-5841-4aa1-9f94-60cfb9aead79","data":"aSDinaTvuI8gbWludGxpZnk="}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSSSEChunkEvent? Chunk { get; init; }
#else
        public global::Cartesia.TTSSSEChunkEvent? Chunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chunk))]
#endif
        public bool IsChunk => Chunk != null;

        /// <summary>
        /// Word-level timing information.<br/>
        /// Example: {"type":"timestamps","done":false,"status_code":206,"context_id":"872ec12d-bc63-4e1e-a241-4f58c879d105","word_timestamps":{"words":["Hello","world"],"start":[0,0.5],"end":[0.4,0.9]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSSSETimestampsEvent? Timestamps { get; init; }
#else
        public global::Cartesia.TTSSSETimestampsEvent? Timestamps { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Timestamps))]
#endif
        public bool IsTimestamps => Timestamps != null;

        /// <summary>
        /// Phoneme-level timing information.<br/>
        /// Example: {"type":"phoneme_timestamps","done":false,"status_code":206,"context_id":"872ec12d-bc63-4e1e-a241-4f58c879d105","phoneme_timestamps":{"phonemes":["h","\u0259","l","o\u028A"],"start":[0.093,0.174,0.255,0.337],"end":[0.174,0.255,0.337,0.418]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSSSEPhonemeTimestampsEvent? PhonemeTimestamps { get; init; }
#else
        public global::Cartesia.TTSSSEPhonemeTimestampsEvent? PhonemeTimestamps { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhonemeTimestamps))]
#endif
        public bool IsPhonemeTimestamps => PhonemeTimestamps != null;

        /// <summary>
        /// Generation completion signal. Final event in the stream.<br/>
        /// Example: {"type":"done","done":true,"status_code":206,"context_id":"50dc3b5e-5841-4aa1-9f94-60cfb9aead79"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSSSEDoneEvent? Done { get; init; }
#else
        public global::Cartesia.TTSSSEDoneEvent? Done { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        /// Error information for the TTS SSE request.<br/>
        /// Example: {"type":"error","done":true,"title":"Invalid model","message":"The model is not valid, make sure it is a valid model ID.","error_code":"model_not_found","status_code":400,"doc_url":"https://docs.cartesia.ai/build-with-cartesia/tts-models/latest","request_id":"2ff8af53-4d38-479d-8287-58940f01c701","context_id":"50dc3b5e-5841-4aa1-9f94-60cfb9aead79"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TTSSSEErrorEvent? Error { get; init; }
#else
        public global::Cartesia.TTSSSEErrorEvent? Error { get; }
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
        public static implicit operator TTSSSEEvent(global::Cartesia.TTSSSEChunkEvent value) => new TTSSSEEvent((global::Cartesia.TTSSSEChunkEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSSSEChunkEvent?(TTSSSEEvent @this) => @this.Chunk;

        /// <summary>
        /// 
        /// </summary>
        public TTSSSEEvent(global::Cartesia.TTSSSEChunkEvent? value)
        {
            Chunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSSSEEvent(global::Cartesia.TTSSSETimestampsEvent value) => new TTSSSEEvent((global::Cartesia.TTSSSETimestampsEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSSSETimestampsEvent?(TTSSSEEvent @this) => @this.Timestamps;

        /// <summary>
        /// 
        /// </summary>
        public TTSSSEEvent(global::Cartesia.TTSSSETimestampsEvent? value)
        {
            Timestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSSSEEvent(global::Cartesia.TTSSSEPhonemeTimestampsEvent value) => new TTSSSEEvent((global::Cartesia.TTSSSEPhonemeTimestampsEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSSSEPhonemeTimestampsEvent?(TTSSSEEvent @this) => @this.PhonemeTimestamps;

        /// <summary>
        /// 
        /// </summary>
        public TTSSSEEvent(global::Cartesia.TTSSSEPhonemeTimestampsEvent? value)
        {
            PhonemeTimestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSSSEEvent(global::Cartesia.TTSSSEDoneEvent value) => new TTSSSEEvent((global::Cartesia.TTSSSEDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSSSEDoneEvent?(TTSSSEEvent @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public TTSSSEEvent(global::Cartesia.TTSSSEDoneEvent? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TTSSSEEvent(global::Cartesia.TTSSSEErrorEvent value) => new TTSSSEEvent((global::Cartesia.TTSSSEErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.TTSSSEErrorEvent?(TTSSSEEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public TTSSSEEvent(global::Cartesia.TTSSSEErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TTSSSEEvent(
            global::Cartesia.TTSSSEEventDiscriminatorType? type,
            global::Cartesia.TTSSSEChunkEvent? chunk,
            global::Cartesia.TTSSSETimestampsEvent? timestamps,
            global::Cartesia.TTSSSEPhonemeTimestampsEvent? phonemeTimestamps,
            global::Cartesia.TTSSSEDoneEvent? done,
            global::Cartesia.TTSSSEErrorEvent? error
            )
        {
            Type = type;

            Chunk = chunk;
            Timestamps = timestamps;
            PhonemeTimestamps = phonemeTimestamps;
            Done = done;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Done as object ??
            PhonemeTimestamps as object ??
            Timestamps as object ??
            Chunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chunk?.ToString() ??
            Timestamps?.ToString() ??
            PhonemeTimestamps?.ToString() ??
            Done?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChunk && !IsTimestamps && !IsPhonemeTimestamps && !IsDone && !IsError || !IsChunk && IsTimestamps && !IsPhonemeTimestamps && !IsDone && !IsError || !IsChunk && !IsTimestamps && IsPhonemeTimestamps && !IsDone && !IsError || !IsChunk && !IsTimestamps && !IsPhonemeTimestamps && IsDone && !IsError || !IsChunk && !IsTimestamps && !IsPhonemeTimestamps && !IsDone && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.TTSSSEChunkEvent?, TResult>? chunk = null,
            global::System.Func<global::Cartesia.TTSSSETimestampsEvent?, TResult>? timestamps = null,
            global::System.Func<global::Cartesia.TTSSSEPhonemeTimestampsEvent?, TResult>? phonemeTimestamps = null,
            global::System.Func<global::Cartesia.TTSSSEDoneEvent?, TResult>? done = null,
            global::System.Func<global::Cartesia.TTSSSEErrorEvent?, TResult>? error = null,
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
            else if (IsTimestamps && timestamps != null)
            {
                return timestamps(Timestamps!);
            }
            else if (IsPhonemeTimestamps && phonemeTimestamps != null)
            {
                return phonemeTimestamps(PhonemeTimestamps!);
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
            global::System.Action<global::Cartesia.TTSSSEChunkEvent?>? chunk = null,
            global::System.Action<global::Cartesia.TTSSSETimestampsEvent?>? timestamps = null,
            global::System.Action<global::Cartesia.TTSSSEPhonemeTimestampsEvent?>? phonemeTimestamps = null,
            global::System.Action<global::Cartesia.TTSSSEDoneEvent?>? done = null,
            global::System.Action<global::Cartesia.TTSSSEErrorEvent?>? error = null,
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
            else if (IsTimestamps)
            {
                timestamps?.Invoke(Timestamps!);
            }
            else if (IsPhonemeTimestamps)
            {
                phonemeTimestamps?.Invoke(PhonemeTimestamps!);
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
                Chunk,
                typeof(global::Cartesia.TTSSSEChunkEvent),
                Timestamps,
                typeof(global::Cartesia.TTSSSETimestampsEvent),
                PhonemeTimestamps,
                typeof(global::Cartesia.TTSSSEPhonemeTimestampsEvent),
                Done,
                typeof(global::Cartesia.TTSSSEDoneEvent),
                Error,
                typeof(global::Cartesia.TTSSSEErrorEvent),
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
        public bool Equals(TTSSSEEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSSSEChunkEvent?>.Default.Equals(Chunk, other.Chunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSSSETimestampsEvent?>.Default.Equals(Timestamps, other.Timestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSSSEPhonemeTimestampsEvent?>.Default.Equals(PhonemeTimestamps, other.PhonemeTimestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSSSEDoneEvent?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TTSSSEErrorEvent?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TTSSSEEvent obj1, TTSSSEEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TTSSSEEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TTSSSEEvent obj1, TTSSSEEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TTSSSEEvent o && Equals(o);
        }
    }
}
