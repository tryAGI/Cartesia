#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NullableLanguageOrLocale : global::System.IEquatable<NullableLanguageOrLocale>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.LanguageOrLocale? LanguageOrLocale { get; init; }
#else
        public global::Cartesia.LanguageOrLocale? LanguageOrLocale { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LanguageOrLocale))]
#endif
        public bool IsLanguageOrLocale => LanguageOrLocale != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLanguageOrLocale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.LanguageOrLocale? value)
        {
            value = LanguageOrLocale;
            return IsLanguageOrLocale;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LanguageOrLocale PickLanguageOrLocale() => LanguageOrLocale is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LanguageOrLocale' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.NullableLanguageOrLocaleEnum? Null { get; init; }
#else
        public global::Cartesia.NullableLanguageOrLocaleEnum? Null { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Null))]
#endif
        public bool IsNull => Null != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNull(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.NullableLanguageOrLocaleEnum? value)
        {
            value = Null;
            return IsNull;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.NullableLanguageOrLocaleEnum PickNull() => Null is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Null' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableLanguageOrLocale(global::Cartesia.LanguageOrLocale value) => new NullableLanguageOrLocale((global::Cartesia.LanguageOrLocale?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.LanguageOrLocale?(NullableLanguageOrLocale @this) => @this.LanguageOrLocale;

        /// <summary>
        ///
        /// </summary>
        public NullableLanguageOrLocale(global::Cartesia.LanguageOrLocale? value)
        {
            LanguageOrLocale = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableLanguageOrLocale FromLanguageOrLocale(global::Cartesia.LanguageOrLocale? value) => new NullableLanguageOrLocale(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableLanguageOrLocale(global::Cartesia.NullableLanguageOrLocaleEnum value) => new NullableLanguageOrLocale((global::Cartesia.NullableLanguageOrLocaleEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.NullableLanguageOrLocaleEnum?(NullableLanguageOrLocale @this) => @this.Null;

        /// <summary>
        ///
        /// </summary>
        public NullableLanguageOrLocale(global::Cartesia.NullableLanguageOrLocaleEnum? value)
        {
            Null = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableLanguageOrLocale FromNull(global::Cartesia.NullableLanguageOrLocaleEnum? value) => new NullableLanguageOrLocale(value);

        /// <summary>
        ///
        /// </summary>
        public NullableLanguageOrLocale(
            global::Cartesia.LanguageOrLocale? languageOrLocale,
            global::Cartesia.NullableLanguageOrLocaleEnum? @null
            )
        {
            LanguageOrLocale = languageOrLocale;
            Null = @null;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Null as object ??
            LanguageOrLocale as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            LanguageOrLocale?.ToValueString() ??
            Null?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLanguageOrLocale && !IsNull || !IsLanguageOrLocale && IsNull;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.LanguageOrLocale?, TResult>? languageOrLocale = null,
            global::System.Func<global::Cartesia.NullableLanguageOrLocaleEnum?, TResult>? @null = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LanguageOrLocale is { } __value0 && languageOrLocale != null)
            {
                return languageOrLocale(__value0);
            }
            else if (Null is { } __value1 && @null != null)
            {
                return @null(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.LanguageOrLocale?>? languageOrLocale = null,

            global::System.Action<global::Cartesia.NullableLanguageOrLocaleEnum?>? @null = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LanguageOrLocale is { } __value0)
            {
                languageOrLocale?.Invoke(__value0);
            }
            else if (Null is { } __value1)
            {
                @null?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.LanguageOrLocale?>? languageOrLocale = null,
            global::System.Action<global::Cartesia.NullableLanguageOrLocaleEnum?>? @null = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LanguageOrLocale is { } __value0)
            {
                languageOrLocale?.Invoke(__value0);
            }
            else if (Null is { } __value1)
            {
                @null?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LanguageOrLocale,
                typeof(global::Cartesia.LanguageOrLocale),
                Null,
                typeof(global::Cartesia.NullableLanguageOrLocaleEnum),
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
        public bool Equals(NullableLanguageOrLocale other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.LanguageOrLocale?>.Default.Equals(LanguageOrLocale, other.LanguageOrLocale) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.NullableLanguageOrLocaleEnum?>.Default.Equals(Null, other.Null)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NullableLanguageOrLocale obj1, NullableLanguageOrLocale obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableLanguageOrLocale>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NullableLanguageOrLocale obj1, NullableLanguageOrLocale obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableLanguageOrLocale o && Equals(o);
        }
    }
}
