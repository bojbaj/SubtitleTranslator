using System.Collections.Generic;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Models;

namespace Kookweb.SubtitleTranslator.Domain.Repositories {
    public interface ITVShowRepository {
        Task<IEnumerable<TVShow>> ListAsync ();
    }
}