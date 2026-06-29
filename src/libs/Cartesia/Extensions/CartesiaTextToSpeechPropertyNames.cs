#nullable enable

namespace Cartesia;

/// <summary>
/// Cartesia-specific <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.AdditionalProperties" /> keys.
/// </summary>
public static class CartesiaTextToSpeechPropertyNames
{
    /// <summary>Boolean flag that requests phoneme-level timestamp events from the SSE endpoint.</summary>
    public const string AddPhonemeTimestamps = "cartesia:add_phoneme_timestamps";

    /// <summary>Boolean flag that requests word-level timestamp events from the SSE endpoint.</summary>
    public const string AddTimestamps = "cartesia:add_timestamps";

    /// <summary>MP3 bit rate in bits per second.</summary>
    public const string BitRate = "cartesia:bit_rate";

    /// <summary>Caller-provided Cartesia streaming context identifier.</summary>
    public const string ContextId = "cartesia:context_id";

    /// <summary>Cartesia emotion control value, such as <c>calm</c> or <c>content</c>.</summary>
    public const string Emotion = "cartesia:emotion";

    /// <summary>Pronunciation dictionary identifier to use for synthesis.</summary>
    public const string PronunciationDictionaryId = "cartesia:pronunciation_dict_id";

    /// <summary>Audio sample rate in Hz.</summary>
    public const string SampleRate = "cartesia:sample_rate";

    /// <summary>Boolean flag that requests Cartesia to save the generated audio file.</summary>
    public const string Save = "cartesia:save";

    /// <summary>Status code returned on Cartesia streaming events.</summary>
    public const string StatusCode = "cartesia:status_code";

    /// <summary>Server-side processing time in milliseconds for a Cartesia streaming chunk.</summary>
    public const string StepTime = "cartesia:step_time";

    /// <summary>Boolean flag that asks Cartesia to normalize emitted timestamps.</summary>
    public const string UseNormalizedTimestamps = "cartesia:use_normalized_timestamps";
}
