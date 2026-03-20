
#nullable enable

namespace Cartesia
{
    /// <summary>
    /// The primary emotions are `neutral`, `calm`, `angry`, `content`, `sad`, `scared`. For more options, see [Prompting Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion#emotion-controls-beta).
    /// </summary>
    public enum Emotion
    {
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Excited,
        /// <summary>
        /// 
        /// </summary>
        Enthusiastic,
        /// <summary>
        /// 
        /// </summary>
        Elated,
        /// <summary>
        /// 
        /// </summary>
        Euphoric,
        /// <summary>
        /// 
        /// </summary>
        Triumphant,
        /// <summary>
        /// 
        /// </summary>
        Amazed,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
        /// <summary>
        /// 
        /// </summary>
        Flirtatious,
        /// <summary>
        /// 
        /// </summary>
        Curious,
        /// <summary>
        /// 
        /// </summary>
        Content,
        /// <summary>
        /// 
        /// </summary>
        Peaceful,
        /// <summary>
        /// 
        /// </summary>
        Serene,
        /// <summary>
        /// 
        /// </summary>
        Calm,
        /// <summary>
        /// 
        /// </summary>
        Grateful,
        /// <summary>
        /// 
        /// </summary>
        Affectionate,
        /// <summary>
        /// 
        /// </summary>
        Trust,
        /// <summary>
        /// 
        /// </summary>
        Sympathetic,
        /// <summary>
        /// 
        /// </summary>
        Anticipation,
        /// <summary>
        /// 
        /// </summary>
        Mysterious,
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Mad,
        /// <summary>
        /// 
        /// </summary>
        Outraged,
        /// <summary>
        /// 
        /// </summary>
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
        Agitated,
        /// <summary>
        /// 
        /// </summary>
        Threatened,
        /// <summary>
        /// 
        /// </summary>
        Disgusted,
        /// <summary>
        /// 
        /// </summary>
        Contempt,
        /// <summary>
        /// 
        /// </summary>
        Envious,
        /// <summary>
        /// 
        /// </summary>
        Sarcastic,
        /// <summary>
        /// 
        /// </summary>
        Ironic,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Dejected,
        /// <summary>
        /// 
        /// </summary>
        Melancholic,
        /// <summary>
        /// 
        /// </summary>
        Disappointed,
        /// <summary>
        /// 
        /// </summary>
        Hurt,
        /// <summary>
        /// 
        /// </summary>
        Guilty,
        /// <summary>
        /// 
        /// </summary>
        Bored,
        /// <summary>
        /// 
        /// </summary>
        Tired,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Nostalgic,
        /// <summary>
        /// 
        /// </summary>
        Wistful,
        /// <summary>
        /// 
        /// </summary>
        Apologetic,
        /// <summary>
        /// 
        /// </summary>
        Hesitant,
        /// <summary>
        /// 
        /// </summary>
        Insecure,
        /// <summary>
        /// 
        /// </summary>
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Resigned,
        /// <summary>
        /// 
        /// </summary>
        Anxious,
        /// <summary>
        /// 
        /// </summary>
        Panicked,
        /// <summary>
        /// 
        /// </summary>
        Alarmed,
        /// <summary>
        /// 
        /// </summary>
        Scared,
        /// <summary>
        /// 
        /// </summary>
        Proud,
        /// <summary>
        /// 
        /// </summary>
        Confident,
        /// <summary>
        /// 
        /// </summary>
        Distant,
        /// <summary>
        /// 
        /// </summary>
        Skeptical,
        /// <summary>
        /// 
        /// </summary>
        Contemplative,
        /// <summary>
        /// 
        /// </summary>
        Determined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Emotion value)
        {
            return value switch
            {
                Emotion.Neutral => "neutral",
                Emotion.Happy => "happy",
                Emotion.Excited => "excited",
                Emotion.Enthusiastic => "enthusiastic",
                Emotion.Elated => "elated",
                Emotion.Euphoric => "euphoric",
                Emotion.Triumphant => "triumphant",
                Emotion.Amazed => "amazed",
                Emotion.Surprised => "surprised",
                Emotion.Flirtatious => "flirtatious",
                Emotion.Curious => "curious",
                Emotion.Content => "content",
                Emotion.Peaceful => "peaceful",
                Emotion.Serene => "serene",
                Emotion.Calm => "calm",
                Emotion.Grateful => "grateful",
                Emotion.Affectionate => "affectionate",
                Emotion.Trust => "trust",
                Emotion.Sympathetic => "sympathetic",
                Emotion.Anticipation => "anticipation",
                Emotion.Mysterious => "mysterious",
                Emotion.Angry => "angry",
                Emotion.Mad => "mad",
                Emotion.Outraged => "outraged",
                Emotion.Frustrated => "frustrated",
                Emotion.Agitated => "agitated",
                Emotion.Threatened => "threatened",
                Emotion.Disgusted => "disgusted",
                Emotion.Contempt => "contempt",
                Emotion.Envious => "envious",
                Emotion.Sarcastic => "sarcastic",
                Emotion.Ironic => "ironic",
                Emotion.Sad => "sad",
                Emotion.Dejected => "dejected",
                Emotion.Melancholic => "melancholic",
                Emotion.Disappointed => "disappointed",
                Emotion.Hurt => "hurt",
                Emotion.Guilty => "guilty",
                Emotion.Bored => "bored",
                Emotion.Tired => "tired",
                Emotion.Rejected => "rejected",
                Emotion.Nostalgic => "nostalgic",
                Emotion.Wistful => "wistful",
                Emotion.Apologetic => "apologetic",
                Emotion.Hesitant => "hesitant",
                Emotion.Insecure => "insecure",
                Emotion.Confused => "confused",
                Emotion.Resigned => "resigned",
                Emotion.Anxious => "anxious",
                Emotion.Panicked => "panicked",
                Emotion.Alarmed => "alarmed",
                Emotion.Scared => "scared",
                Emotion.Proud => "proud",
                Emotion.Confident => "confident",
                Emotion.Distant => "distant",
                Emotion.Skeptical => "skeptical",
                Emotion.Contemplative => "contemplative",
                Emotion.Determined => "determined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Emotion? ToEnum(string value)
        {
            return value switch
            {
                "neutral" => Emotion.Neutral,
                "happy" => Emotion.Happy,
                "excited" => Emotion.Excited,
                "enthusiastic" => Emotion.Enthusiastic,
                "elated" => Emotion.Elated,
                "euphoric" => Emotion.Euphoric,
                "triumphant" => Emotion.Triumphant,
                "amazed" => Emotion.Amazed,
                "surprised" => Emotion.Surprised,
                "flirtatious" => Emotion.Flirtatious,
                "curious" => Emotion.Curious,
                "content" => Emotion.Content,
                "peaceful" => Emotion.Peaceful,
                "serene" => Emotion.Serene,
                "calm" => Emotion.Calm,
                "grateful" => Emotion.Grateful,
                "affectionate" => Emotion.Affectionate,
                "trust" => Emotion.Trust,
                "sympathetic" => Emotion.Sympathetic,
                "anticipation" => Emotion.Anticipation,
                "mysterious" => Emotion.Mysterious,
                "angry" => Emotion.Angry,
                "mad" => Emotion.Mad,
                "outraged" => Emotion.Outraged,
                "frustrated" => Emotion.Frustrated,
                "agitated" => Emotion.Agitated,
                "threatened" => Emotion.Threatened,
                "disgusted" => Emotion.Disgusted,
                "contempt" => Emotion.Contempt,
                "envious" => Emotion.Envious,
                "sarcastic" => Emotion.Sarcastic,
                "ironic" => Emotion.Ironic,
                "sad" => Emotion.Sad,
                "dejected" => Emotion.Dejected,
                "melancholic" => Emotion.Melancholic,
                "disappointed" => Emotion.Disappointed,
                "hurt" => Emotion.Hurt,
                "guilty" => Emotion.Guilty,
                "bored" => Emotion.Bored,
                "tired" => Emotion.Tired,
                "rejected" => Emotion.Rejected,
                "nostalgic" => Emotion.Nostalgic,
                "wistful" => Emotion.Wistful,
                "apologetic" => Emotion.Apologetic,
                "hesitant" => Emotion.Hesitant,
                "insecure" => Emotion.Insecure,
                "confused" => Emotion.Confused,
                "resigned" => Emotion.Resigned,
                "anxious" => Emotion.Anxious,
                "panicked" => Emotion.Panicked,
                "alarmed" => Emotion.Alarmed,
                "scared" => Emotion.Scared,
                "proud" => Emotion.Proud,
                "confident" => Emotion.Confident,
                "distant" => Emotion.Distant,
                "skeptical" => Emotion.Skeptical,
                "contemplative" => Emotion.Contemplative,
                "determined" => Emotion.Determined,
                _ => null,
            };
        }
    }
}