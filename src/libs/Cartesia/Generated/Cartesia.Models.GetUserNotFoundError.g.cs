#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Example: {"request_id":"c20b0fe8-6f68-4439-8d96-e79da4637bf3","message":"The user does not exist in this organization.","title":"User not found"}
    /// </summary>
    public readonly partial struct GetUserNotFoundError : global::System.IEquatable<GetUserNotFoundError>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.PublicErrorResponse? PublicErrorResponse { get; init; }
#else
        public global::Cartesia.PublicErrorResponse? PublicErrorResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicErrorResponse))]
#endif
        public bool IsPublicErrorResponse => PublicErrorResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicErrorResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.PublicErrorResponse? value)
        {
            value = PublicErrorResponse;
            return IsPublicErrorResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PublicErrorResponse PickPublicErrorResponse() => IsPublicErrorResponse
            ? PublicErrorResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicErrorResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetUserNotFoundError(global::Cartesia.PublicErrorResponse value) => new GetUserNotFoundError((global::Cartesia.PublicErrorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.PublicErrorResponse?(GetUserNotFoundError @this) => @this.PublicErrorResponse;

        /// <summary>
        ///
        /// </summary>
        public GetUserNotFoundError(global::Cartesia.PublicErrorResponse? value)
        {
            PublicErrorResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetUserNotFoundError FromPublicErrorResponse(global::Cartesia.PublicErrorResponse? value) => new GetUserNotFoundError(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PublicErrorResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PublicErrorResponse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPublicErrorResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.PublicErrorResponse, TResult>? publicErrorResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPublicErrorResponse && publicErrorResponse != null)
            {
                return publicErrorResponse(PublicErrorResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.PublicErrorResponse>? publicErrorResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPublicErrorResponse)
            {
                publicErrorResponse?.Invoke(PublicErrorResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.PublicErrorResponse>? publicErrorResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPublicErrorResponse)
            {
                publicErrorResponse?.Invoke(PublicErrorResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PublicErrorResponse,
                typeof(global::Cartesia.PublicErrorResponse),
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
        public bool Equals(GetUserNotFoundError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.PublicErrorResponse?>.Default.Equals(PublicErrorResponse, other.PublicErrorResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GetUserNotFoundError obj1, GetUserNotFoundError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetUserNotFoundError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetUserNotFoundError obj1, GetUserNotFoundError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetUserNotFoundError o && Equals(o);
        }
    }
}
