#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Models to fall back to when the primary model fails before it starts responding. `auto` uses Cartesia-managed fallback models. `explicit` uses up to three model IDs from `GET /v1/agents/models`, in order. Set to `null` to disable fallback. Defaults to `auto`.
    /// </summary>
    public readonly partial struct ManagedAgentFallbackStrategyV1 : global::System.IEquatable<ManagedAgentFallbackStrategyV1>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.ManagedAgentFallbackStrategyV1Auto? Auto { get; init; }
#else
        public global::Cartesia.ManagedAgentFallbackStrategyV1Auto? Auto { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAuto(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.ManagedAgentFallbackStrategyV1Auto? value)
        {
            value = Auto;
            return IsAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Auto PickAuto() => Auto is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Auto' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? Explicit { get; init; }
#else
        public global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? Explicit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Explicit))]
#endif
        public bool IsExplicit => Explicit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExplicit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? value)
        {
            value = Explicit;
            return IsExplicit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ManagedAgentFallbackStrategyV1Explicit PickExplicit() => Explicit is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Explicit' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Disabled { get; init; }
#else
        public object? Disabled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDisabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedAgentFallbackStrategyV1(global::Cartesia.ManagedAgentFallbackStrategyV1Auto value) => new ManagedAgentFallbackStrategyV1((global::Cartesia.ManagedAgentFallbackStrategyV1Auto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.ManagedAgentFallbackStrategyV1Auto?(ManagedAgentFallbackStrategyV1 @this) => @this.Auto;

        /// <summary>
        ///
        /// </summary>
        public ManagedAgentFallbackStrategyV1(global::Cartesia.ManagedAgentFallbackStrategyV1Auto? value)
        {
            Auto = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedAgentFallbackStrategyV1 FromAuto(global::Cartesia.ManagedAgentFallbackStrategyV1Auto? value) => new ManagedAgentFallbackStrategyV1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ManagedAgentFallbackStrategyV1(global::Cartesia.ManagedAgentFallbackStrategyV1Explicit value) => new ManagedAgentFallbackStrategyV1((global::Cartesia.ManagedAgentFallbackStrategyV1Explicit?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.ManagedAgentFallbackStrategyV1Explicit?(ManagedAgentFallbackStrategyV1 @this) => @this.Explicit;

        /// <summary>
        ///
        /// </summary>
        public ManagedAgentFallbackStrategyV1(global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? value)
        {
            Explicit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ManagedAgentFallbackStrategyV1 FromExplicit(global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? value) => new ManagedAgentFallbackStrategyV1(value);

        /// <summary>
        ///
        /// </summary>
        public ManagedAgentFallbackStrategyV1(
            global::Cartesia.ManagedAgentFallbackStrategyV1Auto? auto,
            global::Cartesia.ManagedAgentFallbackStrategyV1Explicit? @explicit,
            object? disabled
            )
        {
            Auto = auto;
            Explicit = @explicit;
            Disabled = disabled;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Disabled as object ??
            Explicit as object ??
            Auto as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Auto?.ToString() ??
            Explicit?.ToString() ??
            Disabled?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAuto && !IsExplicit && !IsDisabled || !IsAuto && IsExplicit && !IsDisabled || !IsAuto && !IsExplicit && IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.ManagedAgentFallbackStrategyV1Auto, TResult>? auto = null,
            global::System.Func<global::Cartesia.ManagedAgentFallbackStrategyV1Explicit, TResult>? @explicit = null,
            global::System.Func<object, TResult>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Auto is { } __value0 && auto != null)
            {
                return auto(__value0);
            }
            else if (Explicit is { } __value1 && @explicit != null)
            {
                return @explicit(__value1);
            }
            else if (Disabled is { } __value2 && disabled != null)
            {
                return disabled(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.ManagedAgentFallbackStrategyV1Auto>? auto = null,

            global::System.Action<global::Cartesia.ManagedAgentFallbackStrategyV1Explicit>? @explicit = null,

            global::System.Action<object>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Auto is { } __value0)
            {
                auto?.Invoke(__value0);
            }
            else if (Explicit is { } __value1)
            {
                @explicit?.Invoke(__value1);
            }
            else if (Disabled is { } __value2)
            {
                disabled?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.ManagedAgentFallbackStrategyV1Auto>? auto = null,
            global::System.Action<global::Cartesia.ManagedAgentFallbackStrategyV1Explicit>? @explicit = null,
            global::System.Action<object>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Auto is { } __value0)
            {
                auto?.Invoke(__value0);
            }
            else if (Explicit is { } __value1)
            {
                @explicit?.Invoke(__value1);
            }
            else if (Disabled is { } __value2)
            {
                disabled?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Auto,
                typeof(global::Cartesia.ManagedAgentFallbackStrategyV1Auto),
                Explicit,
                typeof(global::Cartesia.ManagedAgentFallbackStrategyV1Explicit),
                Disabled,
                typeof(object),
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
        public bool Equals(ManagedAgentFallbackStrategyV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.ManagedAgentFallbackStrategyV1Auto?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.ManagedAgentFallbackStrategyV1Explicit?>.Default.Equals(Explicit, other.Explicit) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ManagedAgentFallbackStrategyV1 obj1, ManagedAgentFallbackStrategyV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagedAgentFallbackStrategyV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ManagedAgentFallbackStrategyV1 obj1, ManagedAgentFallbackStrategyV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagedAgentFallbackStrategyV1 o && Equals(o);
        }
    }
}
