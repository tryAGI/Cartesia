#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// An event emitted by the Voice Changer SSE stream.
    /// </summary>
    public readonly partial struct VoiceChangerSSEEvent : global::System.IEquatable<VoiceChangerSSEEvent>
    {
        /// <summary>
        /// Audio data chunk.<br/>
        /// Example: {"done":false,"status_code":206,"step_time":123,"data":"aSDinaTvuI8gbWludGxpZnk=","sample_rate":44100}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.VoiceChangerSSEChunk? VoiceChangerSSEChunk { get; init; }
#else
        public global::Cartesia.VoiceChangerSSEChunk? VoiceChangerSSEChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceChangerSSEChunk))]
#endif
        public bool IsVoiceChangerSSEChunk => VoiceChangerSSEChunk != null;

        /// <summary>
        /// Generation completion signal. Final event in the stream.<br/>
        /// Example: {"done":true,"status_code":200}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.VoiceChangerSSEDone? VoiceChangerSSEDone { get; init; }
#else
        public global::Cartesia.VoiceChangerSSEDone? VoiceChangerSSEDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceChangerSSEDone))]
#endif
        public bool IsVoiceChangerSSEDone => VoiceChangerSSEDone != null;

        /// <summary>
        /// Error information for the Voice Changer SSE request.<br/>
        /// Example: {"type":"error","done":true,"title":"Invalid voice","message":"The voice is not valid, make sure it is a valid voice ID.","error_code":"voice_not_found","status_code":400,"request_id":"2ff8af53-4d38-479d-8287-58940f01c701"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.VoiceChangerSSEError? VoiceChangerSSEError { get; init; }
#else
        public global::Cartesia.VoiceChangerSSEError? VoiceChangerSSEError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceChangerSSEError))]
#endif
        public bool IsVoiceChangerSSEError => VoiceChangerSSEError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceChangerSSEEvent(global::Cartesia.VoiceChangerSSEChunk value) => new VoiceChangerSSEEvent((global::Cartesia.VoiceChangerSSEChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.VoiceChangerSSEChunk?(VoiceChangerSSEEvent @this) => @this.VoiceChangerSSEChunk;

        /// <summary>
        /// 
        /// </summary>
        public VoiceChangerSSEEvent(global::Cartesia.VoiceChangerSSEChunk? value)
        {
            VoiceChangerSSEChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceChangerSSEEvent(global::Cartesia.VoiceChangerSSEDone value) => new VoiceChangerSSEEvent((global::Cartesia.VoiceChangerSSEDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.VoiceChangerSSEDone?(VoiceChangerSSEEvent @this) => @this.VoiceChangerSSEDone;

        /// <summary>
        /// 
        /// </summary>
        public VoiceChangerSSEEvent(global::Cartesia.VoiceChangerSSEDone? value)
        {
            VoiceChangerSSEDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceChangerSSEEvent(global::Cartesia.VoiceChangerSSEError value) => new VoiceChangerSSEEvent((global::Cartesia.VoiceChangerSSEError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.VoiceChangerSSEError?(VoiceChangerSSEEvent @this) => @this.VoiceChangerSSEError;

        /// <summary>
        /// 
        /// </summary>
        public VoiceChangerSSEEvent(global::Cartesia.VoiceChangerSSEError? value)
        {
            VoiceChangerSSEError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VoiceChangerSSEEvent(
            global::Cartesia.VoiceChangerSSEChunk? voiceChangerSSEChunk,
            global::Cartesia.VoiceChangerSSEDone? voiceChangerSSEDone,
            global::Cartesia.VoiceChangerSSEError? voiceChangerSSEError
            )
        {
            VoiceChangerSSEChunk = voiceChangerSSEChunk;
            VoiceChangerSSEDone = voiceChangerSSEDone;
            VoiceChangerSSEError = voiceChangerSSEError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VoiceChangerSSEError as object ??
            VoiceChangerSSEDone as object ??
            VoiceChangerSSEChunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VoiceChangerSSEChunk?.ToString() ??
            VoiceChangerSSEDone?.ToString() ??
            VoiceChangerSSEError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVoiceChangerSSEChunk && !IsVoiceChangerSSEDone && !IsVoiceChangerSSEError || !IsVoiceChangerSSEChunk && IsVoiceChangerSSEDone && !IsVoiceChangerSSEError || !IsVoiceChangerSSEChunk && !IsVoiceChangerSSEDone && IsVoiceChangerSSEError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.VoiceChangerSSEChunk?, TResult>? voiceChangerSSEChunk = null,
            global::System.Func<global::Cartesia.VoiceChangerSSEDone?, TResult>? voiceChangerSSEDone = null,
            global::System.Func<global::Cartesia.VoiceChangerSSEError?, TResult>? voiceChangerSSEError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVoiceChangerSSEChunk && voiceChangerSSEChunk != null)
            {
                return voiceChangerSSEChunk(VoiceChangerSSEChunk!);
            }
            else if (IsVoiceChangerSSEDone && voiceChangerSSEDone != null)
            {
                return voiceChangerSSEDone(VoiceChangerSSEDone!);
            }
            else if (IsVoiceChangerSSEError && voiceChangerSSEError != null)
            {
                return voiceChangerSSEError(VoiceChangerSSEError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.VoiceChangerSSEChunk?>? voiceChangerSSEChunk = null,
            global::System.Action<global::Cartesia.VoiceChangerSSEDone?>? voiceChangerSSEDone = null,
            global::System.Action<global::Cartesia.VoiceChangerSSEError?>? voiceChangerSSEError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVoiceChangerSSEChunk)
            {
                voiceChangerSSEChunk?.Invoke(VoiceChangerSSEChunk!);
            }
            else if (IsVoiceChangerSSEDone)
            {
                voiceChangerSSEDone?.Invoke(VoiceChangerSSEDone!);
            }
            else if (IsVoiceChangerSSEError)
            {
                voiceChangerSSEError?.Invoke(VoiceChangerSSEError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VoiceChangerSSEChunk,
                typeof(global::Cartesia.VoiceChangerSSEChunk),
                VoiceChangerSSEDone,
                typeof(global::Cartesia.VoiceChangerSSEDone),
                VoiceChangerSSEError,
                typeof(global::Cartesia.VoiceChangerSSEError),
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
        public bool Equals(VoiceChangerSSEEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.VoiceChangerSSEChunk?>.Default.Equals(VoiceChangerSSEChunk, other.VoiceChangerSSEChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.VoiceChangerSSEDone?>.Default.Equals(VoiceChangerSSEDone, other.VoiceChangerSSEDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.VoiceChangerSSEError?>.Default.Equals(VoiceChangerSSEError, other.VoiceChangerSSEError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VoiceChangerSSEEvent obj1, VoiceChangerSSEEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VoiceChangerSSEEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VoiceChangerSSEEvent obj1, VoiceChangerSSEEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VoiceChangerSSEEvent o && Equals(o);
        }
    }
}
