#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The number supports inbound calls and outbound calls to US numbers only
    /// </summary>
    public readonly partial struct ProvisionPhoneNumberResponse : global::System.IEquatable<ProvisionPhoneNumberResponse>
    {
        /// <summary>
        /// Common phone number fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.PhoneNumberBaseResponse? PhoneNumberBaseResponse { get; init; }
#else
        public global::Cartesia.PhoneNumberBaseResponse? PhoneNumberBaseResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhoneNumberBaseResponse))]
#endif
        public bool IsPhoneNumberBaseResponse => PhoneNumberBaseResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPhoneNumberBaseResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.PhoneNumberBaseResponse? value)
        {
            value = PhoneNumberBaseResponse;
            return IsPhoneNumberBaseResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberBaseResponse PickPhoneNumberBaseResponse() => IsPhoneNumberBaseResponse
            ? PhoneNumberBaseResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PhoneNumberBaseResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProvisionPhoneNumberResponse(global::Cartesia.PhoneNumberBaseResponse value) => new ProvisionPhoneNumberResponse((global::Cartesia.PhoneNumberBaseResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.PhoneNumberBaseResponse?(ProvisionPhoneNumberResponse @this) => @this.PhoneNumberBaseResponse;

        /// <summary>
        ///
        /// </summary>
        public ProvisionPhoneNumberResponse(global::Cartesia.PhoneNumberBaseResponse? value)
        {
            PhoneNumberBaseResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProvisionPhoneNumberResponse FromPhoneNumberBaseResponse(global::Cartesia.PhoneNumberBaseResponse? value) => new ProvisionPhoneNumberResponse(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PhoneNumberBaseResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PhoneNumberBaseResponse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPhoneNumberBaseResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.PhoneNumberBaseResponse, TResult>? phoneNumberBaseResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhoneNumberBaseResponse && phoneNumberBaseResponse != null)
            {
                return phoneNumberBaseResponse(PhoneNumberBaseResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.PhoneNumberBaseResponse>? phoneNumberBaseResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhoneNumberBaseResponse)
            {
                phoneNumberBaseResponse?.Invoke(PhoneNumberBaseResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.PhoneNumberBaseResponse>? phoneNumberBaseResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhoneNumberBaseResponse)
            {
                phoneNumberBaseResponse?.Invoke(PhoneNumberBaseResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PhoneNumberBaseResponse,
                typeof(global::Cartesia.PhoneNumberBaseResponse),
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
        public bool Equals(ProvisionPhoneNumberResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.PhoneNumberBaseResponse?>.Default.Equals(PhoneNumberBaseResponse, other.PhoneNumberBaseResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProvisionPhoneNumberResponse obj1, ProvisionPhoneNumberResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProvisionPhoneNumberResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProvisionPhoneNumberResponse obj1, ProvisionPhoneNumberResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProvisionPhoneNumberResponse o && Equals(o);
        }
    }
}
