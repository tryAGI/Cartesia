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
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? Value1 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? Value2 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? Value3 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? Value4 { get; init; }
#else
        public global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?(StreamingTranscriptionResponse @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?(StreamingTranscriptionResponse @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?(StreamingTranscriptionResponse @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage> value) => new StreamingTranscriptionResponse((global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?(StreamingTranscriptionResponse @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamingTranscriptionResponse(
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>? value1,
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>? value2,
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>? value3,
            global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?, TResult>? value1 = null,
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?, TResult>? value2 = null,
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?, TResult>? value3 = null,
            global::System.Func<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?>? value1 = null,
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?>? value2 = null,
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?>? value3 = null,
            global::System.Action<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>),
                Value2,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>),
                Value3,
                typeof(global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>),
                Value4,
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
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant12, global::Cartesia.TranscriptMessage>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant22, global::Cartesia.FlushDoneMessage>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant32, global::Cartesia.DoneMessage>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.AllOf<global::Cartesia.StreamingTranscriptionResponseVariant42, global::Cartesia.ErrorMessage>?>.Default.Equals(Value4, other.Value4) 
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
