using System.Collections.Generic;
using Kookweb.SubtitleTranslator.Domain.Models.Enums;
using Kookweb.SubtitleTranslator.Domain.Models.Base;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class tblTVShow : BaseEntity {
        public string Name { get; set; }
        public EnumShowType ShowType { get; set; }
        public IEnumerable<tblTranslate> Translates { get; set; }
    }
}