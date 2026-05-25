#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputFormat : global::System.IEquatable<OutputFormat>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.RawOutputFormat? RawOutputFormat { get; init; }
#else
        public global::Cartesia.RawOutputFormat? RawOutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RawOutputFormat))]
#endif
        public bool IsRawOutputFormat => RawOutputFormat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRawOutputFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.RawOutputFormat? value)
        {
            value = RawOutputFormat;
            return IsRawOutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.RawOutputFormat PickRawOutputFormat() => IsRawOutputFormat
            ? RawOutputFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RawOutputFormat' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.WAVOutputFormat? WAVOutputFormat { get; init; }
#else
        public global::Cartesia.WAVOutputFormat? WAVOutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WAVOutputFormat))]
#endif
        public bool IsWAVOutputFormat => WAVOutputFormat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWAVOutputFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WAVOutputFormat? value)
        {
            value = WAVOutputFormat;
            return IsWAVOutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.WAVOutputFormat PickWAVOutputFormat() => IsWAVOutputFormat
            ? WAVOutputFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WAVOutputFormat' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.MP3OutputFormat? MP3OutputFormat { get; init; }
#else
        public global::Cartesia.MP3OutputFormat? MP3OutputFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MP3OutputFormat))]
#endif
        public bool IsMP3OutputFormat => MP3OutputFormat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMP3OutputFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.MP3OutputFormat? value)
        {
            value = MP3OutputFormat;
            return IsMP3OutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.MP3OutputFormat PickMP3OutputFormat() => IsMP3OutputFormat
            ? MP3OutputFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MP3OutputFormat' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat(global::Cartesia.RawOutputFormat value) => new OutputFormat((global::Cartesia.RawOutputFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.RawOutputFormat?(OutputFormat @this) => @this.RawOutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(global::Cartesia.RawOutputFormat? value)
        {
            RawOutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputFormat FromRawOutputFormat(global::Cartesia.RawOutputFormat? value) => new OutputFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat(global::Cartesia.WAVOutputFormat value) => new OutputFormat((global::Cartesia.WAVOutputFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.WAVOutputFormat?(OutputFormat @this) => @this.WAVOutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(global::Cartesia.WAVOutputFormat? value)
        {
            WAVOutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputFormat FromWAVOutputFormat(global::Cartesia.WAVOutputFormat? value) => new OutputFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFormat(global::Cartesia.MP3OutputFormat value) => new OutputFormat((global::Cartesia.MP3OutputFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.MP3OutputFormat?(OutputFormat @this) => @this.MP3OutputFormat;

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(global::Cartesia.MP3OutputFormat? value)
        {
            MP3OutputFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputFormat FromMP3OutputFormat(global::Cartesia.MP3OutputFormat? value) => new OutputFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputFormat(
            global::Cartesia.RawOutputFormat? rawOutputFormat,
            global::Cartesia.WAVOutputFormat? wAVOutputFormat,
            global::Cartesia.MP3OutputFormat? mP3OutputFormat
            )
        {
            RawOutputFormat = rawOutputFormat;
            WAVOutputFormat = wAVOutputFormat;
            MP3OutputFormat = mP3OutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MP3OutputFormat as object ??
            WAVOutputFormat as object ??
            RawOutputFormat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RawOutputFormat?.ToString() ??
            WAVOutputFormat?.ToString() ??
            MP3OutputFormat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRawOutputFormat && !IsWAVOutputFormat && !IsMP3OutputFormat || !IsRawOutputFormat && IsWAVOutputFormat && !IsMP3OutputFormat || !IsRawOutputFormat && !IsWAVOutputFormat && IsMP3OutputFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.RawOutputFormat, TResult>? rawOutputFormat = null,
            global::System.Func<global::Cartesia.WAVOutputFormat, TResult>? wAVOutputFormat = null,
            global::System.Func<global::Cartesia.MP3OutputFormat, TResult>? mP3OutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawOutputFormat && rawOutputFormat != null)
            {
                return rawOutputFormat(RawOutputFormat!);
            }
            else if (IsWAVOutputFormat && wAVOutputFormat != null)
            {
                return wAVOutputFormat(WAVOutputFormat!);
            }
            else if (IsMP3OutputFormat && mP3OutputFormat != null)
            {
                return mP3OutputFormat(MP3OutputFormat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.RawOutputFormat>? rawOutputFormat = null,

            global::System.Action<global::Cartesia.WAVOutputFormat>? wAVOutputFormat = null,

            global::System.Action<global::Cartesia.MP3OutputFormat>? mP3OutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawOutputFormat)
            {
                rawOutputFormat?.Invoke(RawOutputFormat!);
            }
            else if (IsWAVOutputFormat)
            {
                wAVOutputFormat?.Invoke(WAVOutputFormat!);
            }
            else if (IsMP3OutputFormat)
            {
                mP3OutputFormat?.Invoke(MP3OutputFormat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.RawOutputFormat>? rawOutputFormat = null,
            global::System.Action<global::Cartesia.WAVOutputFormat>? wAVOutputFormat = null,
            global::System.Action<global::Cartesia.MP3OutputFormat>? mP3OutputFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawOutputFormat)
            {
                rawOutputFormat?.Invoke(RawOutputFormat!);
            }
            else if (IsWAVOutputFormat)
            {
                wAVOutputFormat?.Invoke(WAVOutputFormat!);
            }
            else if (IsMP3OutputFormat)
            {
                mP3OutputFormat?.Invoke(MP3OutputFormat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RawOutputFormat,
                typeof(global::Cartesia.RawOutputFormat),
                WAVOutputFormat,
                typeof(global::Cartesia.WAVOutputFormat),
                MP3OutputFormat,
                typeof(global::Cartesia.MP3OutputFormat),
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
        public bool Equals(OutputFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.RawOutputFormat?>.Default.Equals(RawOutputFormat, other.RawOutputFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WAVOutputFormat?>.Default.Equals(WAVOutputFormat, other.WAVOutputFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.MP3OutputFormat?>.Default.Equals(MP3OutputFormat, other.MP3OutputFormat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputFormat obj1, OutputFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputFormat obj1, OutputFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputFormat o && Equals(o);
        }
    }
}
