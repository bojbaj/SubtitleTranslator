using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kookweb.SubtitleTranslator.Domain.Models.Base {
    public class BaseEntity {
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}