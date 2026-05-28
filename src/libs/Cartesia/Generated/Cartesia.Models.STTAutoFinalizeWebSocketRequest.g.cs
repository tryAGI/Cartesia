#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Text messages sent from the client to the server.<br/>
    /// Audio data is sent as raw binary messages rather than text messages.
    /// </summary>
    public readonly partial struct STTAutoFinalizeWebSocketRequest : global::System.IEquatable<STTAutoFinalizeWebSocketRequest>
    {
        /// <summary>
        /// Sent as a JSON-encoded WebSocket text frame to close the session cleanly. All buffered audio will be processed by the model into events before the connection closes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Cartesia.STTAutoFinalizeCloseCommand? STTAutoFinalizeCloseCommand { get; init; }
#else
        public global::Cartesia.STTAutoFinalizeCloseCommand? STTAutoFinalizeCloseCommand { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(STTAutoFinalizeCloseCommand))]
#endif
        public bool IsSTTAutoFinalizeCloseCommand => STTAutoFinalizeCloseCommand != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSTTAutoFinalizeCloseCommand(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Cartesia.STTAutoFinalizeCloseCommand? value)
        {
            value = STTAutoFinalizeCloseCommand;
            return IsSTTAutoFinalizeCloseCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Cartesia.STTAutoFinalizeCloseCommand PickSTTAutoFinalizeCloseCommand() => IsSTTAutoFinalizeCloseCommand
            ? STTAutoFinalizeCloseCommand!
            : throw new global::System.InvalidOperationException($"Expected union variant 'STTAutoFinalizeCloseCommand' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator STTAutoFinalizeWebSocketRequest(global::Cartesia.STTAutoFinalizeCloseCommand value) => new STTAutoFinalizeWebSocketRequest((global::Cartesia.STTAutoFinalizeCloseCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Cartesia.STTAutoFinalizeCloseCommand?(STTAutoFinalizeWebSocketRequest @this) => @this.STTAutoFinalizeCloseCommand;

        /// <summary>
        /// 
        /// </summary>
        public STTAutoFinalizeWebSocketRequest(global::Cartesia.STTAutoFinalizeCloseCommand? value)
        {
            STTAutoFinalizeCloseCommand = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static STTAutoFinalizeWebSocketRequest FromSTTAutoFinalizeCloseCommand(global::Cartesia.STTAutoFinalizeCloseCommand? value) => new STTAutoFinalizeWebSocketRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            STTAutoFinalizeCloseCommand as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            STTAutoFinalizeCloseCommand?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSTTAutoFinalizeCloseCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Cartesia.STTAutoFinalizeCloseCommand, TResult>? sTTAutoFinalizeCloseCommand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSTTAutoFinalizeCloseCommand && sTTAutoFinalizeCloseCommand != null)
            {
                return sTTAutoFinalizeCloseCommand(STTAutoFinalizeCloseCommand!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Cartesia.STTAutoFinalizeCloseCommand>? sTTAutoFinalizeCloseCommand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSTTAutoFinalizeCloseCommand)
            {
                sTTAutoFinalizeCloseCommand?.Invoke(STTAutoFinalizeCloseCommand!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Cartesia.STTAutoFinalizeCloseCommand>? sTTAutoFinalizeCloseCommand = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSTTAutoFinalizeCloseCommand)
            {
                sTTAutoFinalizeCloseCommand?.Invoke(STTAutoFinalizeCloseCommand!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                STTAutoFinalizeCloseCommand,
                typeof(global::Cartesia.STTAutoFinalizeCloseCommand),
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
        public bool Equals(STTAutoFinalizeWebSocketRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Cartesia.STTAutoFinalizeCloseCommand?>.Default.Equals(STTAutoFinalizeCloseCommand, other.STTAutoFinalizeCloseCommand) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(STTAutoFinalizeWebSocketRequest obj1, STTAutoFinalizeWebSocketRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<STTAutoFinalizeWebSocketRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(STTAutoFinalizeWebSocketRequest obj1, STTAutoFinalizeWebSocketRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTAutoFinalizeWebSocketRequest o && Equals(o);
        }
    }
}
