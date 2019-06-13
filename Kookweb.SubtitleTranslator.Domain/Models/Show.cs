using System.Collections.Generic;
using Kookweb.SubtitleTranslator.Domain.Models.Enums;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class TVShow {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnumShowType ShowType { get; set; }
        public IEnumerable<Translate> Translates { get; set; }
    }
}