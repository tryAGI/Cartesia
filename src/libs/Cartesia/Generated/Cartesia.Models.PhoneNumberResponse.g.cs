#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A phone number with its provider and agent assignment details.
    /// </summary>
    public readonly partial struct PhoneNumberResponse : global::System.IEquatable<PhoneNumberResponse>
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
#if NET6_0_OR_GREATER
        public global::Cartesia.PhoneNumberResponseVariant2? PhoneNumberResponseVariant2 { get; init; }
#else
        public global::Cartesia.PhoneNumberResponseVariant2? PhoneNumberResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhoneNumberResponseVariant2))]
#endif
        public bool IsPhoneNumberResponseVariant2 => PhoneNumberResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPhoneNumberResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.PhoneNumberResponseVariant2? value)
        {
            value = PhoneNumberResponseVariant2;
            return IsPhoneNumberResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.PhoneNumberResponseVariant2 PickPhoneNumberResponseVariant2() => IsPhoneNumberResponseVariant2
            ? PhoneNumberResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PhoneNumberResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PhoneNumberResponse(global::Cartesia.PhoneNumberBaseResponse value) => new PhoneNumberResponse((global::Cartesia.PhoneNumberBaseResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.PhoneNumberBaseResponse?(PhoneNumberResponse @this) => @this.PhoneNumberBaseResponse;

        /// <summary>
        ///
        /// </summary>
        public PhoneNumberResponse(global::Cartesia.PhoneNumberBaseResponse? value)
        {
            PhoneNumberBaseResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PhoneNumberResponse FromPhoneNumberBaseResponse(global::Cartesia.PhoneNumberBaseResponse? value) => new PhoneNumberResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PhoneNumberResponse(global::Cartesia.PhoneNumberResponseVariant2 value) => new PhoneNumberResponse((global::Cartesia.PhoneNumberResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.PhoneNumberResponseVariant2?(PhoneNumberResponse @this) => @this.PhoneNumberResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public PhoneNumberResponse(global::Cartesia.PhoneNumberResponseVariant2? value)
        {
            PhoneNumberResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PhoneNumberResponse FromPhoneNumberResponseVariant2(global::Cartesia.PhoneNumberResponseVariant2? value) => new PhoneNumberResponse(value);

        /// <summary>
        ///
        /// </summary>
        public PhoneNumberResponse(
            global::Cartesia.PhoneNumberBaseResponse? phoneNumberBaseResponse,
            global::Cartesia.PhoneNumberResponseVariant2? phoneNumberResponseVariant2
            )
        {
            PhoneNumberBaseResponse = phoneNumberBaseResponse;
            PhoneNumberResponseVariant2 = phoneNumberResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PhoneNumberResponseVariant2 as object ??
            PhoneNumberBaseResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PhoneNumberBaseResponse?.ToString() ??
            PhoneNumberResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPhoneNumberBaseResponse && IsPhoneNumberResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.PhoneNumberBaseResponse, TResult>? phoneNumberBaseResponse = null,
            global::System.Func<global::Cartesia.PhoneNumberResponseVariant2, TResult>? phoneNumberResponseVariant2 = null,
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
            else if (IsPhoneNumberResponseVariant2 && phoneNumberResponseVariant2 != null)
            {
                return phoneNumberResponseVariant2(PhoneNumberResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.PhoneNumberBaseResponse>? phoneNumberBaseResponse = null,

            global::System.Action<global::Cartesia.PhoneNumberResponseVariant2>? phoneNumberResponseVariant2 = null,
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
            else if (IsPhoneNumberResponseVariant2)
            {
                phoneNumberResponseVariant2?.Invoke(PhoneNumberResponseVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.PhoneNumberBaseResponse>? phoneNumberBaseResponse = null,
            global::System.Action<global::Cartesia.PhoneNumberResponseVariant2>? phoneNumberResponseVariant2 = null,
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
            else if (IsPhoneNumberResponseVariant2)
            {
                phoneNumberResponseVariant2?.Invoke(PhoneNumberResponseVariant2!);
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
                PhoneNumberResponseVariant2,
                typeof(global::Cartesia.PhoneNumberResponseVariant2),
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
        public bool Equals(PhoneNumberResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.PhoneNumberBaseResponse?>.Default.Equals(PhoneNumberBaseResponse, other.PhoneNumberBaseResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.PhoneNumberResponseVariant2?>.Default.Equals(PhoneNumberResponseVariant2, other.PhoneNumberResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PhoneNumberResponse obj1, PhoneNumberResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PhoneNumberResponse obj1, PhoneNumberResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberResponse o && Equals(o);
        }
    }
}
