#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Authentication sent in the `Authorization` header.
    /// </summary>
    public readonly partial struct WebhookAuthenticationResponse : global::System.IEquatable<WebhookAuthenticationResponse>
    {
        /// <summary>
        /// Sends an `Authorization` header using HTTP Basic authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.WebhookAuthenticationResponseVariant1? WebhookAuthenticationResponseVariant1 { get; init; }
#else
        public global::Cartesia.WebhookAuthenticationResponseVariant1? WebhookAuthenticationResponseVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAuthenticationResponseVariant1))]
#endif
        public bool IsWebhookAuthenticationResponseVariant1 => WebhookAuthenticationResponseVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAuthenticationResponseVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WebhookAuthenticationResponseVariant1? value)
        {
            value = WebhookAuthenticationResponseVariant1;
            return IsWebhookAuthenticationResponseVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant1 PickWebhookAuthenticationResponseVariant1() => IsWebhookAuthenticationResponseVariant1
            ? WebhookAuthenticationResponseVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAuthenticationResponseVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Sends an `Authorization` header using a bearer token.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.WebhookAuthenticationResponseVariant2? WebhookAuthenticationResponseVariant2 { get; init; }
#else
        public global::Cartesia.WebhookAuthenticationResponseVariant2? WebhookAuthenticationResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAuthenticationResponseVariant2))]
#endif
        public bool IsWebhookAuthenticationResponseVariant2 => WebhookAuthenticationResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAuthenticationResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WebhookAuthenticationResponseVariant2? value)
        {
            value = WebhookAuthenticationResponseVariant2;
            return IsWebhookAuthenticationResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationResponseVariant2 PickWebhookAuthenticationResponseVariant2() => IsWebhookAuthenticationResponseVariant2
            ? WebhookAuthenticationResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAuthenticationResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAuthenticationResponse(global::Cartesia.WebhookAuthenticationResponseVariant1 value) => new WebhookAuthenticationResponse((global::Cartesia.WebhookAuthenticationResponseVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.WebhookAuthenticationResponseVariant1?(WebhookAuthenticationResponse @this) => @this.WebhookAuthenticationResponseVariant1;

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthenticationResponse(global::Cartesia.WebhookAuthenticationResponseVariant1? value)
        {
            WebhookAuthenticationResponseVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAuthenticationResponse FromWebhookAuthenticationResponseVariant1(global::Cartesia.WebhookAuthenticationResponseVariant1? value) => new WebhookAuthenticationResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAuthenticationResponse(global::Cartesia.WebhookAuthenticationResponseVariant2 value) => new WebhookAuthenticationResponse((global::Cartesia.WebhookAuthenticationResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.WebhookAuthenticationResponseVariant2?(WebhookAuthenticationResponse @this) => @this.WebhookAuthenticationResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthenticationResponse(global::Cartesia.WebhookAuthenticationResponseVariant2? value)
        {
            WebhookAuthenticationResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAuthenticationResponse FromWebhookAuthenticationResponseVariant2(global::Cartesia.WebhookAuthenticationResponseVariant2? value) => new WebhookAuthenticationResponse(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthenticationResponse(
            global::Cartesia.WebhookAuthenticationResponseVariant1? webhookAuthenticationResponseVariant1,
            global::Cartesia.WebhookAuthenticationResponseVariant2? webhookAuthenticationResponseVariant2
            )
        {
            WebhookAuthenticationResponseVariant1 = webhookAuthenticationResponseVariant1;
            WebhookAuthenticationResponseVariant2 = webhookAuthenticationResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAuthenticationResponseVariant2 as object ??
            WebhookAuthenticationResponseVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WebhookAuthenticationResponseVariant1?.ToString() ??
            WebhookAuthenticationResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebhookAuthenticationResponseVariant1 && !IsWebhookAuthenticationResponseVariant2 || !IsWebhookAuthenticationResponseVariant1 && IsWebhookAuthenticationResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.WebhookAuthenticationResponseVariant1, TResult>? webhookAuthenticationResponseVariant1 = null,
            global::System.Func<global::Cartesia.WebhookAuthenticationResponseVariant2, TResult>? webhookAuthenticationResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookAuthenticationResponseVariant1 && webhookAuthenticationResponseVariant1 != null)
            {
                return webhookAuthenticationResponseVariant1(WebhookAuthenticationResponseVariant1!);
            }
            else if (IsWebhookAuthenticationResponseVariant2 && webhookAuthenticationResponseVariant2 != null)
            {
                return webhookAuthenticationResponseVariant2(WebhookAuthenticationResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.WebhookAuthenticationResponseVariant1>? webhookAuthenticationResponseVariant1 = null,

            global::System.Action<global::Cartesia.WebhookAuthenticationResponseVariant2>? webhookAuthenticationResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookAuthenticationResponseVariant1)
            {
                webhookAuthenticationResponseVariant1?.Invoke(WebhookAuthenticationResponseVariant1!);
            }
            else if (IsWebhookAuthenticationResponseVariant2)
            {
                webhookAuthenticationResponseVariant2?.Invoke(WebhookAuthenticationResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.WebhookAuthenticationResponseVariant1>? webhookAuthenticationResponseVariant1 = null,
            global::System.Action<global::Cartesia.WebhookAuthenticationResponseVariant2>? webhookAuthenticationResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookAuthenticationResponseVariant1)
            {
                webhookAuthenticationResponseVariant1?.Invoke(WebhookAuthenticationResponseVariant1!);
            }
            else if (IsWebhookAuthenticationResponseVariant2)
            {
                webhookAuthenticationResponseVariant2?.Invoke(WebhookAuthenticationResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookAuthenticationResponseVariant1,
                typeof(global::Cartesia.WebhookAuthenticationResponseVariant1),
                WebhookAuthenticationResponseVariant2,
                typeof(global::Cartesia.WebhookAuthenticationResponseVariant2),
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
        public bool Equals(WebhookAuthenticationResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WebhookAuthenticationResponseVariant1?>.Default.Equals(WebhookAuthenticationResponseVariant1, other.WebhookAuthenticationResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WebhookAuthenticationResponseVariant2?>.Default.Equals(WebhookAuthenticationResponseVariant2, other.WebhookAuthenticationResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAuthenticationResponse obj1, WebhookAuthenticationResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAuthenticationResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAuthenticationResponse obj1, WebhookAuthenticationResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAuthenticationResponse o && Equals(o);
        }
    }
}
