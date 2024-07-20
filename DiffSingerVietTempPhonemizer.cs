using OpenUtau.Api;

namespace OpenUtau.Core.DiffSinger {
    [Phonemizer("DiffSinger Temporary Vietnamese Phonemizer", "DIFFS VI", "Lotte V", language: "VI")]
    /// <summary>
    /// Simple makeshift Vietnamese phonemizer for DiffSinger voicebanks.
    /// There's nothing fancy about this, no G2P or anything, only custom dict support.
    /// I will not merge this upstream, since in my opinion, an in-built Vietnamese phonemizer would need a proper G2P dictionary.
    /// Feel free to ship this with your own voicebanks, along with the dsdict I made; just credit me for making them.
    /// </summary>
    public class DiffSingerVietTempPhonemizer : DiffSingerBasePhonemizer {
        protected override string GetDictionaryName() => "dsdict-vi.yaml";
    }
}
