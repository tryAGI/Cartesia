#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Text messages sent from the client to the server.<br/>
    /// Audio data is sent as raw binary messages rather than text messages.
    /// </summary>
    public readonly partial struct STTTurnsWebSocketRequest : global::System.IEquatable<STTTurnsWebSocketRequest>
    {
        /// <summary>
        /// Sent as a JSON-encoded WebSocket text frame to close the session cleanly. All buffered audio will be processed by the model into events before the connection closes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTTurnsCloseCommand? STTTurnsCloseCommand { get; init; }
#else
        public global::Cartesia.STTTurnsCloseCommand? STTTurnsCloseCommand { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(STTTurnsCloseCommand))]
#endif
        public bool IsSTTTurnsCloseCommand => STTTurnsCloseCommand != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSTTTurnsCloseCommand(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.STTTurnsCloseCommand? value)
        {
            value = STTTurnsCloseCommand;
            return IsSTTTurnsCloseCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTTurnsCloseCommand PickSTTTurnsCloseCommand() => IsSTTTurnsCloseCommand
            ? STTTurnsCloseCommand!
            : throw new global::System.InvalidOperationException($"Expected union variant 'STTTurnsCloseCommand' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTTurnsWebSocketRequest(global::Cartesia.STTTurnsCloseCommand value) => new STTTurnsWebSocketRequest((global::Cartesia.STTTurnsCloseCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTTurnsCloseCommand?(STTTurnsWebSocketRequest @this) => @this.STTTurnsCloseCommand;

        /// <summary>
        /// 
        /// </summary>
        public STTTurnsWebSocketRequest(global::Cartesia.STTTurnsCloseCommand? value)
        {
            STTTurnsCloseCommand = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTTurnsWebSocketRequest FromSTTTurnsCloseCommand(global::Cartesia.STTTurnsCloseCommand? value) => new STTTurnsWebSocketRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            STTTurnsCloseCommand as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            STTTurnsCloseCommand?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSTTTurnsCloseCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.STTTurnsCloseCommand, TResult>? sTTTurnsCloseCommand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSTTTurnsCloseCommand && sTTTurnsCloseCommand != null)
            {
                return sTTTurnsCloseCommand(STTTurnsCloseCommand!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.STTTurnsCloseCommand>? sTTTurnsCloseCommand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSTTTurnsCloseCommand)
            {
                sTTTurnsCloseCommand?.Invoke(STTTurnsCloseCommand!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.STTTurnsCloseCommand>? sTTTurnsCloseCommand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSTTTurnsCloseCommand)
            {
                sTTTurnsCloseCommand?.Invoke(STTTurnsCloseCommand!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                STTTurnsCloseCommand,
                typeof(global::Cartesia.STTTurnsCloseCommand),
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
        public bool Equals(STTTurnsWebSocketRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTTurnsCloseCommand?>.Default.Equals(STTTurnsCloseCommand, other.STTTurnsCloseCommand) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(STTTurnsWebSocketRequest obj1, STTTurnsWebSocketRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<STTTurnsWebSocketRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(STTTurnsWebSocketRequest obj1, STTTurnsWebSocketRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTTurnsWebSocketRequest o && Equals(o);
        }
    }
}
