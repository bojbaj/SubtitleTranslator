using System.Collections.Generic;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Models;
using Kookweb.SubtitleTranslator.Domain.Repositories;
using Kookweb.SubtitleTranslator.Domain.Services;

namespace Kookweb.SubtitleTranslator.Services {
    public class TVShowService : ITVShowService {
        private readonly ITVShowRepository _tvShowRepository;

        public TVShowService (ITVShowRepository tvShowRepository) {
            this._tvShowRepository = tvShowRepository;
        }
        public Task<IEnumerable<tblTVShow>> ListAsync () {
            return _tvShowRepository.ListAsync ();
        }
    }
}