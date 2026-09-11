#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Example: {"request_id":"691becb2-3fe9-4f17-9c7a-4c565882f75a","message":"\u2716 Cannot specify both ending_before and starting_after parameters","title":"Invalid request"}
    /// </summary>
    public readonly partial struct ListUsersBadRequestError : global::System.IEquatable<ListUsersBadRequestError>
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
        public static implicit operator ListUsersBadRequestError(global::Cartesia.PublicErrorResponse value) => new ListUsersBadRequestError((global::Cartesia.PublicErrorResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.PublicErrorResponse?(ListUsersBadRequestError @this) => @this.PublicErrorResponse;

        /// <summary>
        ///
        /// </summary>
        public ListUsersBadRequestError(global::Cartesia.PublicErrorResponse? value)
        {
            PublicErrorResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListUsersBadRequestError FromPublicErrorResponse(global::Cartesia.PublicErrorResponse? value) => new ListUsersBadRequestError(value);

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
        public bool Equals(ListUsersBadRequestError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.PublicErrorResponse?>.Default.Equals(PublicErrorResponse, other.PublicErrorResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListUsersBadRequestError obj1, ListUsersBadRequestError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListUsersBadRequestError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListUsersBadRequestError obj1, ListUsersBadRequestError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListUsersBadRequestError o && Equals(o);
        }
    }
}
