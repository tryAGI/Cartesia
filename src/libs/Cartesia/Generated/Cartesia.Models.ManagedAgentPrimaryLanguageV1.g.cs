#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The language the agent starts each call in: a language, such as `en`, or a locale, such as `en-US`. See [supported languages and locales](/build-with-cartesia/capability-guides/advanced-capabilities#which-locales-are-supported).
    /// </summary>
    public readonly partial struct ManagedAgentPrimaryLanguageV1 : global::System.IEquatable<ManagedAgentPrimaryLanguageV1>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.LanguageOrLocale? OrLocale { get; init; }
#else
        public global::Cartesia.LanguageOrLocale? OrLocale { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrLocale))]
#endif
        public bool IsOrLocale => OrLocale != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOrLocale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.LanguageOrLocale? value)
        {
            value = OrLocale;
            return IsOrLocale;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.LanguageOrLocale PickOrLocale() => OrLocale is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrLocale' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedAgentPrimaryLanguageV1(global::Cartesia.LanguageOrLocale value) => new ManagedAgentPrimaryLanguageV1((global::Cartesia.LanguageOrLocale?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.LanguageOrLocale?(ManagedAgentPrimaryLanguageV1 @this) => @this.OrLocale;

        /// <summary>
        ///
        /// </summary>
        public ManagedAgentPrimaryLanguageV1(global::Cartesia.LanguageOrLocale? value)
        {
            OrLocale = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedAgentPrimaryLanguageV1 FromOrLocale(global::Cartesia.LanguageOrLocale? value) => new ManagedAgentPrimaryLanguageV1(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OrLocale as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OrLocale?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOrLocale;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.LanguageOrLocale?, TResult>? orLocale = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OrLocale is { } __value0 && orLocale != null)
            {
                return orLocale(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.LanguageOrLocale?>? orLocale = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OrLocale is { } __value0)
            {
                orLocale?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.LanguageOrLocale?>? orLocale = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OrLocale is { } __value0)
            {
                orLocale?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrLocale,
                typeof(global::Cartesia.LanguageOrLocale),
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
        public bool Equals(ManagedAgentPrimaryLanguageV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.LanguageOrLocale?>.Default.Equals(OrLocale, other.OrLocale)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ManagedAgentPrimaryLanguageV1 obj1, ManagedAgentPrimaryLanguageV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagedAgentPrimaryLanguageV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ManagedAgentPrimaryLanguageV1 obj1, ManagedAgentPrimaryLanguageV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagedAgentPrimaryLanguageV1 o && Equals(o);
        }
    }
}
