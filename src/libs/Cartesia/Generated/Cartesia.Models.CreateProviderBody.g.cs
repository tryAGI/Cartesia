#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Request body for linking a telephony provider. Discriminated by `type`.<br/>
    /// **Twilio**:<br/>
    ///   - Credentials are validated against Twilio before the provider is created<br/>
    ///   - Each account SID + region combination can only be linked once
    /// </summary>
    public readonly partial struct CreateProviderBody : global::System.IEquatable<CreateProviderBody>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateProviderBodyDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.CreateTwilioProviderBody? Twilio { get; init; }
#else
        public global::Cartesia.CreateTwilioProviderBody? Twilio { get; }
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
            out global::Cartesia.CreateTwilioProviderBody? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateTwilioProviderBody PickTwilio() => IsTwilio
            ? Twilio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        /// Link a SIP trunk provider. At least one of `inbound` or `outbound` is required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.CreateSIPProviderBody? SipTrunk { get; init; }
#else
        public global::Cartesia.CreateSIPProviderBody? SipTrunk { get; }
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
            out global::Cartesia.CreateSIPProviderBody? value)
        {
            value = SipTrunk;
            return IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.CreateSIPProviderBody PickSipTrunk() => IsSipTrunk
            ? SipTrunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunk' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateProviderBody(global::Cartesia.CreateTwilioProviderBody value) => new CreateProviderBody((global::Cartesia.CreateTwilioProviderBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.CreateTwilioProviderBody?(CreateProviderBody @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public CreateProviderBody(global::Cartesia.CreateTwilioProviderBody? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateProviderBody FromTwilio(global::Cartesia.CreateTwilioProviderBody? value) => new CreateProviderBody(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateProviderBody(global::Cartesia.CreateSIPProviderBody value) => new CreateProviderBody((global::Cartesia.CreateSIPProviderBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Cartesia.CreateSIPProviderBody?(CreateProviderBody @this) => @this.SipTrunk;

        /// <summary>
        ///
        /// </summary>
        public CreateProviderBody(global::Cartesia.CreateSIPProviderBody? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateProviderBody FromSipTrunk(global::Cartesia.CreateSIPProviderBody? value) => new CreateProviderBody(value);

        /// <summary>
        ///
        /// </summary>
        public CreateProviderBody(
            global::Cartesia.CreateProviderBodyDiscriminatorType? type,
            global::Cartesia.CreateTwilioProviderBody? twilio,
            global::Cartesia.CreateSIPProviderBody? sipTrunk
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
            global::System.Func<global::Cartesia.CreateTwilioProviderBody, TResult>? twilio = null,
            global::System.Func<global::Cartesia.CreateSIPProviderBody, TResult>? sipTrunk = null,
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
            global::System.Action<global::Cartesia.CreateTwilioProviderBody>? twilio = null,

            global::System.Action<global::Cartesia.CreateSIPProviderBody>? sipTrunk = null,
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
            global::System.Action<global::Cartesia.CreateTwilioProviderBody>? twilio = null,
            global::System.Action<global::Cartesia.CreateSIPProviderBody>? sipTrunk = null,
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
                typeof(global::Cartesia.CreateTwilioProviderBody),
                SipTrunk,
                typeof(global::Cartesia.CreateSIPProviderBody),
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
        public bool Equals(CreateProviderBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.CreateTwilioProviderBody?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.CreateSIPProviderBody?>.Default.Equals(SipTrunk, other.SipTrunk)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateProviderBody obj1, CreateProviderBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateProviderBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateProviderBody obj1, CreateProviderBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateProviderBody o && Equals(o);
        }
    }
}
