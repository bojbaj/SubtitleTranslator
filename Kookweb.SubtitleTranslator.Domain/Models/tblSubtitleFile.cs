using System.Collections.Generic;
using Kookweb.SubtitleTranslator.Domain.Models.Base;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class tblSubtitleFile : BaseEntity {
        public int LanguageId { get; set; }
        public tblLanguage Language { get; set; }
        public string FilePath { get; set; }
        public IEnumerable<tblTranslate> Translates { get; set; }
    }
}