#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The server sends transcription results, control messages, or error messages. Each message has a `type` field to distinguish between different message types.
    /// </summary>
    public readonly partial struct StreamingTranscriptionResponse : global::System.IEquatable<StreamingTranscriptionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? StreamingTranscriptionResponseVariant1 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? StreamingTranscriptionResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant1))]
#endif
        public bool IsStreamingTranscriptionResponseVariant1 => StreamingTranscriptionResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? StreamingTranscriptionResponseVariant2 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? StreamingTranscriptionResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant2))]
#endif
        public bool IsStreamingTranscriptionResponseVariant2 => StreamingTranscriptionResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? StreamingTranscriptionResponseVariant3 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? StreamingTranscriptionResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant3))]
#endif
        public bool IsStreamingTranscriptionResponseVariant3 => StreamingTranscriptionResponseVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? StreamingTranscriptionResponseVariant4 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? StreamingTranscriptionResponseVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingTranscriptionResponseVariant4))]
#endif
        public bool IsStreamingTranscriptionResponseVariant4 => StreamingTranscriptionResponseVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? value)
        {
            StreamingTranscriptionResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? value)
        {
            StreamingTranscriptionResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? value)
        {
            StreamingTranscriptionResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?(StreamingTranscriptionResponse @this) => @this.StreamingTranscriptionResponseVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? value)
        {
            StreamingTranscriptionResponseVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? streamingTranscriptionResponseVariant1,
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? streamingTranscriptionResponseVariant2,
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? streamingTranscriptionResponseVariant3,
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? streamingTranscriptionResponseVariant4
            )
        {
            StreamingTranscriptionResponseVariant1 = streamingTranscriptionResponseVariant1;
            StreamingTranscriptionResponseVariant2 = streamingTranscriptionResponseVariant2;
            StreamingTranscriptionResponseVariant3 = streamingTranscriptionResponseVariant3;
            StreamingTranscriptionResponseVariant4 = streamingTranscriptionResponseVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamingTranscriptionResponseVariant4 as object ??
            StreamingTranscriptionResponseVariant3 as object ??
            StreamingTranscriptionResponseVariant2 as object ??
            StreamingTranscriptionResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamingTranscriptionResponseVariant1?.ToString() ??
            StreamingTranscriptionResponseVariant2?.ToString() ??
            StreamingTranscriptionResponseVariant3?.ToString() ??
            StreamingTranscriptionResponseVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamingTranscriptionResponseVariant1 && !IsStreamingTranscriptionResponseVariant2 && !IsStreamingTranscriptionResponseVariant3 && !IsStreamingTranscriptionResponseVariant4 || !IsStreamingTranscriptionResponseVariant1 && IsStreamingTranscriptionResponseVariant2 && !IsStreamingTranscriptionResponseVariant3 && !IsStreamingTranscriptionResponseVariant4 || !IsStreamingTranscriptionResponseVariant1 && !IsStreamingTranscriptionResponseVariant2 && IsStreamingTranscriptionResponseVariant3 && !IsStreamingTranscriptionResponseVariant4 || !IsStreamingTranscriptionResponseVariant1 && !IsStreamingTranscriptionResponseVariant2 && !IsStreamingTranscriptionResponseVariant3 && IsStreamingTranscriptionResponseVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?, TResult>? streamingTranscriptionResponseVariant1 = null,
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?, TResult>? streamingTranscriptionResponseVariant2 = null,
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?, TResult>? streamingTranscriptionResponseVariant3 = null,
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?, TResult>? streamingTranscriptionResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamingTranscriptionResponseVariant1 && streamingTranscriptionResponseVariant1 != null)
            {
                return streamingTranscriptionResponseVariant1(StreamingTranscriptionResponseVariant1!);
            }
            else if (IsStreamingTranscriptionResponseVariant2 && streamingTranscriptionResponseVariant2 != null)
            {
                return streamingTranscriptionResponseVariant2(StreamingTranscriptionResponseVariant2!);
            }
            else if (IsStreamingTranscriptionResponseVariant3 && streamingTranscriptionResponseVariant3 != null)
            {
                return streamingTranscriptionResponseVariant3(StreamingTranscriptionResponseVariant3!);
            }
            else if (IsStreamingTranscriptionResponseVariant4 && streamingTranscriptionResponseVariant4 != null)
            {
                return streamingTranscriptionResponseVariant4(StreamingTranscriptionResponseVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?>? streamingTranscriptionResponseVariant1 = null,
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?>? streamingTranscriptionResponseVariant2 = null,
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?>? streamingTranscriptionResponseVariant3 = null,
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?>? streamingTranscriptionResponseVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamingTranscriptionResponseVariant1)
            {
                streamingTranscriptionResponseVariant1?.Invoke(StreamingTranscriptionResponseVariant1!);
            }
            else if (IsStreamingTranscriptionResponseVariant2)
            {
                streamingTranscriptionResponseVariant2?.Invoke(StreamingTranscriptionResponseVariant2!);
            }
            else if (IsStreamingTranscriptionResponseVariant3)
            {
                streamingTranscriptionResponseVariant3?.Invoke(StreamingTranscriptionResponseVariant3!);
            }
            else if (IsStreamingTranscriptionResponseVariant4)
            {
                streamingTranscriptionResponseVariant4?.Invoke(StreamingTranscriptionResponseVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamingTranscriptionResponseVariant1,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>),
                StreamingTranscriptionResponseVariant2,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>),
                StreamingTranscriptionResponseVariant3,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>),
                StreamingTranscriptionResponseVariant4,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>),
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
        public bool Equals(StreamingTranscriptionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant1, other.StreamingTranscriptionResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant2, other.StreamingTranscriptionResponseVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant3, other.StreamingTranscriptionResponseVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?>.Default.Equals(StreamingTranscriptionResponseVariant4, other.StreamingTranscriptionResponseVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamingTranscriptionResponse obj1, StreamingTranscriptionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamingTranscriptionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamingTranscriptionResponse obj1, StreamingTranscriptionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamingTranscriptionResponse o && Equals(o);
        }
    }
}
