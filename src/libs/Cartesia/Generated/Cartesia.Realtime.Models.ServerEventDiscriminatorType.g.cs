
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AudioOutput,
        /// <summary>
        ///
        /// </summary>
        AudioOutputClear,
        /// <summary>
        ///
        /// </summary>
        ClientToolCall,
        /// <summary>
        ///
        /// </summary>
        DtmfOutput,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        SessionReady,
        /// <summary>
        ///
        /// </summary>
        TurnEnded,
        /// <summary>
        ///
        /// </summary>
        TurnOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        TurnStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.AudioOutput => "audio_output",
                ServerEventDiscriminatorType.AudioOutputClear => "audio_output_clear",
                ServerEventDiscriminatorType.ClientToolCall => "client_tool_call",
                ServerEventDiscriminatorType.DtmfOutput => "dtmf_output",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.SessionReady => "session_ready",
                ServerEventDiscriminatorType.TurnEnded => "turn_ended",
                ServerEventDiscriminatorType.TurnOutputTextDelta => "turn_output_text_delta",
                ServerEventDiscriminatorType.TurnStarted => "turn_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_output" => ServerEventDiscriminatorType.AudioOutput,
                "audio_output_clear" => ServerEventDiscriminatorType.AudioOutputClear,
                "client_tool_call" => ServerEventDiscriminatorType.ClientToolCall,
                "dtmf_output" => ServerEventDiscriminatorType.DtmfOutput,
                "error" => ServerEventDiscriminatorType.Error,
                "session_ready" => ServerEventDiscriminatorType.SessionReady,
                "turn_ended" => ServerEventDiscriminatorType.TurnEnded,
                "turn_output_text_delta" => ServerEventDiscriminatorType.TurnOutputTextDelta,
                "turn_started" => ServerEventDiscriminatorType.TurnStarted,
                _ => null,
            };
        }
    }
}