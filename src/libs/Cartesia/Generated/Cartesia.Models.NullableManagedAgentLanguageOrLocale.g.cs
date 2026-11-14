#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NullableManagedAgentLanguageOrLocale : global::System.IEquatable<NullableManagedAgentLanguageOrLocale>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.ManagedAgentLanguageOrLocale? ManagedAgentLanguageOrLocale { get; init; }
#else
        public global::Cartesia.ManagedAgentLanguageOrLocale? ManagedAgentLanguageOrLocale { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ManagedAgentLanguageOrLocale))]
#endif
        public bool IsManagedAgentLanguageOrLocale => ManagedAgentLanguageOrLocale != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickManagedAgentLanguageOrLocale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.ManagedAgentLanguageOrLocale? value)
        {
            value = ManagedAgentLanguageOrLocale;
            return IsManagedAgentLanguageOrLocale;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentLanguageOrLocale PickManagedAgentLanguageOrLocale() => ManagedAgentLanguageOrLocale is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ManagedAgentLanguageOrLocale' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? Null { get; init; }
#else
        public global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? Null { get; }
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
            out global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? value)
        {
            value = Null;
            return IsNull;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum PickNull() => Null is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Null' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableManagedAgentLanguageOrLocale(global::Cartesia.ManagedAgentLanguageOrLocale value) => new NullableManagedAgentLanguageOrLocale((global::Cartesia.ManagedAgentLanguageOrLocale?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.ManagedAgentLanguageOrLocale?(NullableManagedAgentLanguageOrLocale @this) => @this.ManagedAgentLanguageOrLocale;

        /// <summary>
        ///
        /// </summary>
        public NullableManagedAgentLanguageOrLocale(global::Cartesia.ManagedAgentLanguageOrLocale? value)
        {
            ManagedAgentLanguageOrLocale = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableManagedAgentLanguageOrLocale FromManagedAgentLanguageOrLocale(global::Cartesia.ManagedAgentLanguageOrLocale? value) => new NullableManagedAgentLanguageOrLocale(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableManagedAgentLanguageOrLocale(global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum value) => new NullableManagedAgentLanguageOrLocale((global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum?(NullableManagedAgentLanguageOrLocale @this) => @this.Null;

        /// <summary>
        ///
        /// </summary>
        public NullableManagedAgentLanguageOrLocale(global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? value)
        {
            Null = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableManagedAgentLanguageOrLocale FromNull(global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? value) => new NullableManagedAgentLanguageOrLocale(value);

        /// <summary>
        ///
        /// </summary>
        public NullableManagedAgentLanguageOrLocale(
            global::Cartesia.ManagedAgentLanguageOrLocale? managedAgentLanguageOrLocale,
            global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum? @null
            )
        {
            ManagedAgentLanguageOrLocale = managedAgentLanguageOrLocale;
            Null = @null;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Null as object ??
            ManagedAgentLanguageOrLocale as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ManagedAgentLanguageOrLocale?.ToValueString() ??
            Null?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsManagedAgentLanguageOrLocale && !IsNull || !IsManagedAgentLanguageOrLocale && IsNull;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.ManagedAgentLanguageOrLocale?, TResult>? managedAgentLanguageOrLocale = null,
            global::System.Func<global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum?, TResult>? @null = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedAgentLanguageOrLocale is { } __value0 && managedAgentLanguageOrLocale != null)
            {
                return managedAgentLanguageOrLocale(__value0);
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
            global::System.Action<global::Cartesia.ManagedAgentLanguageOrLocale?>? managedAgentLanguageOrLocale = null,

            global::System.Action<global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum?>? @null = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedAgentLanguageOrLocale is { } __value0)
            {
                managedAgentLanguageOrLocale?.Invoke(__value0);
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
            global::System.Action<global::Cartesia.ManagedAgentLanguageOrLocale?>? managedAgentLanguageOrLocale = null,
            global::System.Action<global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum?>? @null = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedAgentLanguageOrLocale is { } __value0)
            {
                managedAgentLanguageOrLocale?.Invoke(__value0);
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
                ManagedAgentLanguageOrLocale,
                typeof(global::Cartesia.ManagedAgentLanguageOrLocale),
                Null,
                typeof(global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum),
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
        public bool Equals(NullableManagedAgentLanguageOrLocale other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.ManagedAgentLanguageOrLocale?>.Default.Equals(ManagedAgentLanguageOrLocale, other.ManagedAgentLanguageOrLocale) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.NullableManagedAgentLanguageOrLocaleEnum?>.Default.Equals(Null, other.Null)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NullableManagedAgentLanguageOrLocale obj1, NullableManagedAgentLanguageOrLocale obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableManagedAgentLanguageOrLocale>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NullableManagedAgentLanguageOrLocale obj1, NullableManagedAgentLanguageOrLocale obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableManagedAgentLanguageOrLocale o && Equals(o);
        }
    }
}
