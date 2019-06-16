using System.Collections.Generic;
using Kookweb.SubtitleTranslator.Domain.Models.Base;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class tblLanguage: BaseEntity  {
        public string Name { get; set; }
        public IEnumerable<tblTranslate> Translates { get; set; }
        public IEnumerable<tblSubtitleFile> SubtitleFiles { get; set; }
    }
}