#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// A telephony provider account.
    /// </summary>
    public readonly partial struct ProviderAccountResponse : global::System.IEquatable<ProviderAccountResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.ProviderAccountResponseDiscriminatorType? Type { get; }

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
        /// A linked SIP trunk provider.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.SIPTrunkProviderResponse? SipTrunk { get; init; }
#else
        public global::Cartesia.SIPTrunkProviderResponse? SipTrunk { get; }
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
            out global::Cartesia.SIPTrunkProviderResponse? value)
        {
            value = SipTrunk;
            return IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.SIPTrunkProviderResponse PickSipTrunk() => IsSipTrunk
            ? SipTrunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunk' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderAccountResponse(global::Cartesia.TwilioProviderResponse value) => new ProviderAccountResponse((global::Cartesia.TwilioProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.TwilioProviderResponse?(ProviderAccountResponse @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public ProviderAccountResponse(global::Cartesia.TwilioProviderResponse? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderAccountResponse FromTwilio(global::Cartesia.TwilioProviderResponse? value) => new ProviderAccountResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderAccountResponse(global::Cartesia.SIPTrunkProviderResponse value) => new ProviderAccountResponse((global::Cartesia.SIPTrunkProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.SIPTrunkProviderResponse?(ProviderAccountResponse @this) => @this.SipTrunk;

        /// <summary>
        ///
        /// </summary>
        public ProviderAccountResponse(global::Cartesia.SIPTrunkProviderResponse? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderAccountResponse FromSipTrunk(global::Cartesia.SIPTrunkProviderResponse? value) => new ProviderAccountResponse(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderAccountResponse(
            global::Cartesia.ProviderAccountResponseDiscriminatorType? type,
            global::Cartesia.TwilioProviderResponse? twilio,
            global::Cartesia.SIPTrunkProviderResponse? sipTrunk
            )
        {
            Type = type;

            Twilio = twilio;
            SipTrunk = sipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SipTrunk as object ??
            Twilio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunk?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunk || !IsTwilio && IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.TwilioProviderResponse, TResult>? twilio = null,
            global::System.Func<global::Cartesia.SIPTrunkProviderResponse, TResult>? sipTrunk = null,
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

            global::System.Action<global::Cartesia.SIPTrunkProviderResponse>? sipTrunk = null,
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
            global::System.Action<global::Cartesia.SIPTrunkProviderResponse>? sipTrunk = null,
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
                SipTrunk,
                typeof(global::Cartesia.SIPTrunkProviderResponse),
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
        public bool Equals(ProviderAccountResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.TwilioProviderResponse?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.SIPTrunkProviderResponse?>.Default.Equals(SipTrunk, other.SipTrunk)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderAccountResponse obj1, ProviderAccountResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderAccountResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderAccountResponse obj1, ProviderAccountResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderAccountResponse o && Equals(o);
        }
    }
}
