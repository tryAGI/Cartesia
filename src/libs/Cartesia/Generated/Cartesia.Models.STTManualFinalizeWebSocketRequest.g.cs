
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Text commands sent to the server:<br/>
    /// - Send ``finalize`` as a text message when the user is done speaking to receive the transcript for any buffered audio<br/>
    /// - Send ``close`` as a text message to flush remaining audio, close session, and receive a done acknowledgment<br/>
    /// Audio data is sent as raw binary messages.
    /// </summary>
    public enum STTManualFinalizeWebSocketRequest
    {
        /// <summary>
        /// 
        /// </summary>
        Close,
        /// <summary>
        /// 
        /// </summary>
        Finalize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTManualFinalizeWebSocketRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTManualFinalizeWebSocketRequest value)
        {
            return value switch
            {
                STTManualFinalizeWebSocketRequest.Close => "close",
                STTManualFinalizeWebSocketRequest.Finalize => "finalize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTManualFinalizeWebSocketRequest? ToEnum(string value)
        {
            return value switch
            {
                "close" => STTManualFinalizeWebSocketRequest.Close,
                "finalize" => STTManualFinalizeWebSocketRequest.Finalize,
                _ => null,
            };
        }
    }
}