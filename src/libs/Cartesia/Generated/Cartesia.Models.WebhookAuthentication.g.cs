#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Authentication sent in the `Authorization` header.
    /// </summary>
    public readonly partial struct WebhookAuthentication : global::System.IEquatable<WebhookAuthentication>
    {
        /// <summary>
        /// Sends an `Authorization` header using HTTP Basic authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.WebhookAuthenticationVariant1? WebhookAuthenticationVariant1 { get; init; }
#else
        public global::Cartesia.WebhookAuthenticationVariant1? WebhookAuthenticationVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAuthenticationVariant1))]
#endif
        public bool IsWebhookAuthenticationVariant1 => WebhookAuthenticationVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAuthenticationVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WebhookAuthenticationVariant1? value)
        {
            value = WebhookAuthenticationVariant1;
            return IsWebhookAuthenticationVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant1 PickWebhookAuthenticationVariant1() => IsWebhookAuthenticationVariant1
            ? WebhookAuthenticationVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAuthenticationVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Sends an `Authorization` header using a bearer token.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.WebhookAuthenticationVariant2? WebhookAuthenticationVariant2 { get; init; }
#else
        public global::Cartesia.WebhookAuthenticationVariant2? WebhookAuthenticationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAuthenticationVariant2))]
#endif
        public bool IsWebhookAuthenticationVariant2 => WebhookAuthenticationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAuthenticationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WebhookAuthenticationVariant2? value)
        {
            value = WebhookAuthenticationVariant2;
            return IsWebhookAuthenticationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationVariant2 PickWebhookAuthenticationVariant2() => IsWebhookAuthenticationVariant2
            ? WebhookAuthenticationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAuthenticationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAuthentication(global::Cartesia.WebhookAuthenticationVariant1 value) => new WebhookAuthentication((global::Cartesia.WebhookAuthenticationVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.WebhookAuthenticationVariant1?(WebhookAuthentication @this) => @this.WebhookAuthenticationVariant1;

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthentication(global::Cartesia.WebhookAuthenticationVariant1? value)
        {
            WebhookAuthenticationVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAuthentication FromWebhookAuthenticationVariant1(global::Cartesia.WebhookAuthenticationVariant1? value) => new WebhookAuthentication(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAuthentication(global::Cartesia.WebhookAuthenticationVariant2 value) => new WebhookAuthentication((global::Cartesia.WebhookAuthenticationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.WebhookAuthenticationVariant2?(WebhookAuthentication @this) => @this.WebhookAuthenticationVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthentication(global::Cartesia.WebhookAuthenticationVariant2? value)
        {
            WebhookAuthenticationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAuthentication FromWebhookAuthenticationVariant2(global::Cartesia.WebhookAuthenticationVariant2? value) => new WebhookAuthentication(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthentication(
            global::Cartesia.WebhookAuthenticationVariant1? webhookAuthenticationVariant1,
            global::Cartesia.WebhookAuthenticationVariant2? webhookAuthenticationVariant2
            )
        {
            WebhookAuthenticationVariant1 = webhookAuthenticationVariant1;
            WebhookAuthenticationVariant2 = webhookAuthenticationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAuthenticationVariant2 as object ??
            WebhookAuthenticationVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WebhookAuthenticationVariant1?.ToString() ??
            WebhookAuthenticationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebhookAuthenticationVariant1 && !IsWebhookAuthenticationVariant2 || !IsWebhookAuthenticationVariant1 && IsWebhookAuthenticationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.WebhookAuthenticationVariant1, TResult>? webhookAuthenticationVariant1 = null,
            global::System.Func<global::Cartesia.WebhookAuthenticationVariant2, TResult>? webhookAuthenticationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookAuthenticationVariant1 && webhookAuthenticationVariant1 != null)
            {
                return webhookAuthenticationVariant1(WebhookAuthenticationVariant1!);
            }
            else if (IsWebhookAuthenticationVariant2 && webhookAuthenticationVariant2 != null)
            {
                return webhookAuthenticationVariant2(WebhookAuthenticationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.WebhookAuthenticationVariant1>? webhookAuthenticationVariant1 = null,

            global::System.Action<global::Cartesia.WebhookAuthenticationVariant2>? webhookAuthenticationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookAuthenticationVariant1)
            {
                webhookAuthenticationVariant1?.Invoke(WebhookAuthenticationVariant1!);
            }
            else if (IsWebhookAuthenticationVariant2)
            {
                webhookAuthenticationVariant2?.Invoke(WebhookAuthenticationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.WebhookAuthenticationVariant1>? webhookAuthenticationVariant1 = null,
            global::System.Action<global::Cartesia.WebhookAuthenticationVariant2>? webhookAuthenticationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookAuthenticationVariant1)
            {
                webhookAuthenticationVariant1?.Invoke(WebhookAuthenticationVariant1!);
            }
            else if (IsWebhookAuthenticationVariant2)
            {
                webhookAuthenticationVariant2?.Invoke(WebhookAuthenticationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookAuthenticationVariant1,
                typeof(global::Cartesia.WebhookAuthenticationVariant1),
                WebhookAuthenticationVariant2,
                typeof(global::Cartesia.WebhookAuthenticationVariant2),
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
        public bool Equals(WebhookAuthentication other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WebhookAuthenticationVariant1?>.Default.Equals(WebhookAuthenticationVariant1, other.WebhookAuthenticationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WebhookAuthenticationVariant2?>.Default.Equals(WebhookAuthenticationVariant2, other.WebhookAuthenticationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAuthentication obj1, WebhookAuthentication obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAuthentication>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAuthentication obj1, WebhookAuthentication obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAuthentication o && Equals(o);
        }
    }
}
