namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class Translate {
        public int Id { get; set; }
        public int SubtitleFileId { get; set; }
        public SubtitleFile SubtitleFile { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public int TVShowId { get; set; }
        public TVShow TVShow { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}