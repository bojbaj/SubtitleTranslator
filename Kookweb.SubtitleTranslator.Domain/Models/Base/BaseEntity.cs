using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kookweb.SubtitleTranslator.Domain.Models.Base {
    public class BaseEntity {
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }

        public bool IsDeleted { get; set; }
    }
}