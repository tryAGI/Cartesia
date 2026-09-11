
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Cartesia.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionCreateEvent? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionCreateEventType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionCreateEventAudio? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionCreateEventAudioInputFormat? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionCreateEventAudioOutputDelivery? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioInputEvent? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioInputEventType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentDtmfInputEvent? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentDtmfInputEventType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentClientToolResultEvent? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentClientToolResultEventType? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionReadyEvent? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionReadyEventType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentSessionReadyEventAudio? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioOutputEvent? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioOutputEventType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioOutputClearEvent? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentAudioOutputClearEventType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentDtmfOutputEvent? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentDtmfOutputEventType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentClientToolCallEvent? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentClientToolCallEventType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnStartedEvent? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnStartedEventType? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnStartedEventRole? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEvent? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnOutputTextDeltaEventRole? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnEndedEvent? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnEndedEventType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnEndedEventRole? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Cartesia.Realtime.AgentTurnEndedEventToolCall>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentTurnEndedEventToolCall? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentErrorEvent? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentErrorEventType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.AgentErrorEventCode? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.ServerEvent? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.ServerEventDiscriminator? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Cartesia.Realtime.ServerEventDiscriminatorType? Type43 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Cartesia.Realtime.AgentTurnEndedEventToolCall>? ListType0 { get; set; }
    }
}