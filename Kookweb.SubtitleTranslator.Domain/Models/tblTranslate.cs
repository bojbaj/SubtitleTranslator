using Kookweb.SubtitleTranslator.Domain.Models.Base;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class tblTranslate: BaseEntity  {
        public int SubtitleFileId { get; set; }
        public tblSubtitleFile SubtitleFile { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public int TVShowId { get; set; }
        public tblTVShow TVShow { get; set; }
        public int LanguageId { get; set; }
        public tblLanguage Language { get; set; }
    }
}