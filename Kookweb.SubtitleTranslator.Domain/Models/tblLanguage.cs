using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Kookweb.SubtitleTranslator.Domain.Models.Base;

namespace Kookweb.SubtitleTranslator.Domain.Models {
    public class tblLanguage : BaseEntity {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
        public IEnumerable<tblTranslate> Translates { get; set; }
        public IEnumerable<tblSubtitleFile> SubtitleFiles { get; set; }
    }
}