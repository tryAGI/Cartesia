
#nullable enable

namespace Cartesia.Realtime.TextToSpeech
{
    public sealed partial class ChunkResponse
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="Data" />.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> DataBytes => Data is null
            ? default
            : global::System.Convert.FromBase64String(Data);
    }
}