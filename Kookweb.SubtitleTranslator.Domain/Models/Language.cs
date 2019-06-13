using System.Collections.Generic;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class Language {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Translate> Translates { get; set; }
    }
}