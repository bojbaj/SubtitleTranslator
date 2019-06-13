using System.Collections.Generic;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Models;

namespace Kookweb.SubtitleTranslator.Domain.Services {
    public interface ITVShowService {
        Task<IEnumerable<TVShow>> ListAsync ();
    }
}