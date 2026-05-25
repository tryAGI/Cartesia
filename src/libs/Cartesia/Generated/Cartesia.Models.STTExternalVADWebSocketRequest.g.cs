
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// Text commands sent to the server:<br/>
    /// - Send ``finalize`` as a text message when the user is done speaking to receive the transcript for any buffered audio<br/>
    /// - Send ``close`` as a text message to flush remaining audio, close session, and receive a done acknowledgment<br/>
    /// Audio data is sent as raw binary messages.
    /// </summary>
    public enum STTExternalVADWebSocketRequest
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
    public static class STTExternalVADWebSocketRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTExternalVADWebSocketRequest value)
        {
            return value switch
            {
                STTExternalVADWebSocketRequest.Close => "close",
                STTExternalVADWebSocketRequest.Finalize => "finalize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTExternalVADWebSocketRequest? ToEnum(string value)
        {
            return value switch
            {
                "close" => STTExternalVADWebSocketRequest.Close,
                "finalize" => STTExternalVADWebSocketRequest.Finalize,
                _ => null,
            };
        }
    }
}