using System.ComponentModel;

namespace Kookweb.SubtitleTranslator.Domain.Models.Enums {
    public enum EnumShowType : byte {
        [Description ("M")]
        Movie = 1,
        [Description ("S")]
        Series = 2
    }
}