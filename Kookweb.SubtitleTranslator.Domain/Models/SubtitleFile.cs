using System.Collections.Generic;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class SubtitleFile {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string FilePath { get; set; }
        public IEnumerable<Translate> Translates { get; set; }
    }
}