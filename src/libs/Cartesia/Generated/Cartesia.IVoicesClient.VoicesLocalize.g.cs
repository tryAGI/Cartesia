#nullable enable

namespace Cartesia
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Localize Voice<br/>
        /// Create a new voice from an existing voice localized to a new language and dialect.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Cartesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesLocalizeAsync(
            global::Cartesia.VoicesLocalizeCartesiaVersion cartesiaVersion,

            global::Cartesia.LocalizeVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Localize Voice<br/>
        /// Create a new voice from an existing voice localized to a new language and dialect.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to localize.
        /// </param>
        /// <param name="name">
        /// The name of the new localized voice.
        /// </param>
        /// <param name="description">
        /// The description of the new localized voice.
        /// </param>
        /// <param name="language">
        /// Target language to localize the voice to.<br/>
        /// Options: English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </param>
        /// <param name="originalSpeakerGender"></param>
        /// <param name="dialect">
        /// The dialect to localize to. Only supported for English (`en`), Spanish (`es`), Portuguese (`pt`), and French (`fr`).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Cartesia.VoiceMetadata> VoicesLocalizeAsync(
            global::Cartesia.VoicesLocalizeCartesiaVersion cartesiaVersion,
            string voiceId,
            string name,
            string description,
            global::Cartesia.LocalizeTargetLanguage language,
            global::Cartesia.Gender originalSpeakerGender,
            global::Cartesia.LocalizeDialect? dialect = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}