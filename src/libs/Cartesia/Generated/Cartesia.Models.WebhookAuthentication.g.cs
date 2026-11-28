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
        public global::Cartesia.WebhookAuthenticationBasicAuth? BasicAuth { get; init; }
#else
        public global::Cartesia.WebhookAuthenticationBasicAuth? BasicAuth { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicAuth))]
#endif
        public bool IsBasicAuth => BasicAuth != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBasicAuth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WebhookAuthenticationBasicAuth? value)
        {
            value = BasicAuth;
            return IsBasicAuth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationBasicAuth PickBasicAuth() => BasicAuth is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasicAuth' but the value was {ToString()}.");

        /// <summary>
        /// Sends an `Authorization` header using a bearer token.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.WebhookAuthenticationBearerToken? BearerToken { get; init; }
#else
        public global::Cartesia.WebhookAuthenticationBearerToken? BearerToken { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BearerToken))]
#endif
        public bool IsBearerToken => BearerToken != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBearerToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.WebhookAuthenticationBearerToken? value)
        {
            value = BearerToken;
            return IsBearerToken;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.WebhookAuthenticationBearerToken PickBearerToken() => BearerToken is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BearerToken' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAuthentication(global::Cartesia.WebhookAuthenticationBasicAuth value) => new WebhookAuthentication((global::Cartesia.WebhookAuthenticationBasicAuth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.WebhookAuthenticationBasicAuth?(WebhookAuthentication @this) => @this.BasicAuth;

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthentication(global::Cartesia.WebhookAuthenticationBasicAuth? value)
        {
            BasicAuth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAuthentication FromBasicAuth(global::Cartesia.WebhookAuthenticationBasicAuth? value) => new WebhookAuthentication(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAuthentication(global::Cartesia.WebhookAuthenticationBearerToken value) => new WebhookAuthentication((global::Cartesia.WebhookAuthenticationBearerToken?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.WebhookAuthenticationBearerToken?(WebhookAuthentication @this) => @this.BearerToken;

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthentication(global::Cartesia.WebhookAuthenticationBearerToken? value)
        {
            BearerToken = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAuthentication FromBearerToken(global::Cartesia.WebhookAuthenticationBearerToken? value) => new WebhookAuthentication(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAuthentication(
            global::Cartesia.WebhookAuthenticationBasicAuth? basicAuth,
            global::Cartesia.WebhookAuthenticationBearerToken? bearerToken
            )
        {
            BasicAuth = basicAuth;
            BearerToken = bearerToken;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BearerToken as object ??
            BasicAuth as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BasicAuth?.ToString() ??
            BearerToken?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBasicAuth && !IsBearerToken || !IsBasicAuth && IsBearerToken;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.WebhookAuthenticationBasicAuth, TResult>? basicAuth = null,
            global::System.Func<global::Cartesia.WebhookAuthenticationBearerToken, TResult>? bearerToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BasicAuth is { } __value0 && basicAuth != null)
            {
                return basicAuth(__value0);
            }
            else if (BearerToken is { } __value1 && bearerToken != null)
            {
                return bearerToken(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.WebhookAuthenticationBasicAuth>? basicAuth = null,

            global::System.Action<global::Cartesia.WebhookAuthenticationBearerToken>? bearerToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BasicAuth is { } __value0)
            {
                basicAuth?.Invoke(__value0);
            }
            else if (BearerToken is { } __value1)
            {
                bearerToken?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.WebhookAuthenticationBasicAuth>? basicAuth = null,
            global::System.Action<global::Cartesia.WebhookAuthenticationBearerToken>? bearerToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BasicAuth is { } __value0)
            {
                basicAuth?.Invoke(__value0);
            }
            else if (BearerToken is { } __value1)
            {
                bearerToken?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BasicAuth,
                typeof(global::Cartesia.WebhookAuthenticationBasicAuth),
                BearerToken,
                typeof(global::Cartesia.WebhookAuthenticationBearerToken),
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
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WebhookAuthenticationBasicAuth?>.Default.Equals(BasicAuth, other.BasicAuth) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.WebhookAuthenticationBearerToken?>.Default.Equals(BearerToken, other.BearerToken)
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
