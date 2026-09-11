
#nullable enable

namespace Cartesia.Realtime
{
    /// <summary>
    /// How the server delivers agent audio. `speaking_pace` paces audio to playback speed. `as_available` sends it as fast as the model produces it, so a client that buffers locally can play it back on its own clock for lower latency. Not supported when the agent uses a background sound.<br/>
    /// Default Value: speaking_pace
    /// </summary>
    public enum AgentSessionCreateEventAudioOutputDelivery
    {
        /// <summary>
        ///
        /// </summary>
        AsAvailable,
        /// <summary>
        ///
        /// </summary>
        SpeakingPace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionCreateEventAudioOutputDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionCreateEventAudioOutputDelivery value)
        {
            return value switch
            {
                AgentSessionCreateEventAudioOutputDelivery.AsAvailable => "as_available",
                AgentSessionCreateEventAudioOutputDelivery.SpeakingPace => "speaking_pace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionCreateEventAudioOutputDelivery? ToEnum(string value)
        {
            return value switch
            {
                "as_available" => AgentSessionCreateEventAudioOutputDelivery.AsAvailable,
                "speaking_pace" => AgentSessionCreateEventAudioOutputDelivery.SpeakingPace,
                _ => null,
            };
        }
    }
}