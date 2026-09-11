#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The telephony provider associated with a phone number. One of `Twilio`, `Cartesia`, or `SIP Trunk`, determined by the `type` field. For SIP trunk numbers, `inbound` and `outbound` are not returned here — use `GET /agents/phone-numbers/providers/{id}` to retrieve them.
    /// </summary>
    public readonly partial struct ProviderResponse : global::System.IEquatable<ProviderResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// A linked Twilio account. The `api_key_sid` field is partially masked in responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.TwilioProviderResponse? Twilio { get; init; }
#else
        public global::Cartesia.TwilioProviderResponse? Twilio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTwilio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.TwilioProviderResponse? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.TwilioProviderResponse PickTwilio() => IsTwilio
            ? Twilio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        /// A Cartesia-managed provider. US phone numbers only.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.CartesiaProviderResponse? Cartesia { get; init; }
#else
        public global::Cartesia.CartesiaProviderResponse? Cartesia { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cartesia))]
#endif
        public bool IsCartesia => Cartesia != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCartesia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.CartesiaProviderResponse? value)
        {
            value = Cartesia;
            return IsCartesia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CartesiaProviderResponse PickCartesia() => IsCartesia
            ? Cartesia!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cartesia' but the value was {ToString()}.");

        /// <summary>
        /// A linked SIP trunk provider.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.SIPTrunkEmbeddedResponse? SipTrunk { get; init; }
#else
        public global::Cartesia.SIPTrunkEmbeddedResponse? SipTrunk { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipTrunk))]
#endif
        public bool IsSipTrunk => SipTrunk != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSipTrunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.SIPTrunkEmbeddedResponse? value)
        {
            value = SipTrunk;
            return IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkEmbeddedResponse PickSipTrunk() => IsSipTrunk
            ? SipTrunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunk' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderResponse(global::Cartesia.TwilioProviderResponse value) => new ProviderResponse((global::Cartesia.TwilioProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.TwilioProviderResponse?(ProviderResponse @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public ProviderResponse(global::Cartesia.TwilioProviderResponse? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponse FromTwilio(global::Cartesia.TwilioProviderResponse? value) => new ProviderResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderResponse(global::Cartesia.CartesiaProviderResponse value) => new ProviderResponse((global::Cartesia.CartesiaProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.CartesiaProviderResponse?(ProviderResponse @this) => @this.Cartesia;

        /// <summary>
        ///
        /// </summary>
        public ProviderResponse(global::Cartesia.CartesiaProviderResponse? value)
        {
            Cartesia = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponse FromCartesia(global::Cartesia.CartesiaProviderResponse? value) => new ProviderResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderResponse(global::Cartesia.SIPTrunkEmbeddedResponse value) => new ProviderResponse((global::Cartesia.SIPTrunkEmbeddedResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.SIPTrunkEmbeddedResponse?(ProviderResponse @this) => @this.SipTrunk;

        /// <summary>
        ///
        /// </summary>
        public ProviderResponse(global::Cartesia.SIPTrunkEmbeddedResponse? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponse FromSipTrunk(global::Cartesia.SIPTrunkEmbeddedResponse? value) => new ProviderResponse(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderResponse(
            global::Cartesia.ProviderResponseDiscriminatorType? type,
            global::Cartesia.TwilioProviderResponse? twilio,
            global::Cartesia.CartesiaProviderResponse? cartesia,
            global::Cartesia.SIPTrunkEmbeddedResponse? sipTrunk
            )
        {
            Type = type;

            Twilio = twilio;
            Cartesia = cartesia;
            SipTrunk = sipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SipTrunk as object ??
            Cartesia as object ??
            Twilio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            Cartesia?.ToString() ??
            SipTrunk?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsCartesia && !IsSipTrunk || !IsTwilio && IsCartesia && !IsSipTrunk || !IsTwilio && !IsCartesia && IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.TwilioProviderResponse, TResult>? twilio = null,
            global::System.Func<global::Cartesia.CartesiaProviderResponse, TResult>? cartesia = null,
            global::System.Func<global::Cartesia.SIPTrunkEmbeddedResponse, TResult>? sipTrunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsCartesia && cartesia != null)
            {
                return cartesia(Cartesia!);
            }
            else if (IsSipTrunk && sipTrunk != null)
            {
                return sipTrunk(SipTrunk!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.TwilioProviderResponse>? twilio = null,

            global::System.Action<global::Cartesia.CartesiaProviderResponse>? cartesia = null,

            global::System.Action<global::Cartesia.SIPTrunkEmbeddedResponse>? sipTrunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsCartesia)
            {
                cartesia?.Invoke(Cartesia!);
            }
            else if (IsSipTrunk)
            {
                sipTrunk?.Invoke(SipTrunk!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.TwilioProviderResponse>? twilio = null,
            global::System.Action<global::Cartesia.CartesiaProviderResponse>? cartesia = null,
            global::System.Action<global::Cartesia.SIPTrunkEmbeddedResponse>? sipTrunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsCartesia)
            {
                cartesia?.Invoke(Cartesia!);
            }
            else if (IsSipTrunk)
            {
                sipTrunk?.Invoke(SipTrunk!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Twilio,
                typeof(global::Cartesia.TwilioProviderResponse),
                Cartesia,
                typeof(global::Cartesia.CartesiaProviderResponse),
                SipTrunk,
                typeof(global::Cartesia.SIPTrunkEmbeddedResponse),
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
        public bool Equals(ProviderResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TwilioProviderResponse?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.CartesiaProviderResponse?>.Default.Equals(Cartesia, other.Cartesia) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.SIPTrunkEmbeddedResponse?>.Default.Equals(SipTrunk, other.SipTrunk)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderResponse obj1, ProviderResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderResponse obj1, ProviderResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderResponse o && Equals(o);
        }
    }
}
