using System.Collections.Generic;
using System.Threading.Tasks;
using Kookweb.SubtitleTranslator.Domain.Models;
using Kookweb.SubtitleTranslator.Domain.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Kookweb.SubtitleTranslator.Domain.Repositories {
    public class TVShowRepository : BaseRepository, ITVShowRepository {

        public TVShowRepository (AppDbContext context) : base (context) { }

        public async Task<IEnumerable<TVShow>> ListAsync () {
            return await _context.TVShows.ToListAsync ();
        }
    }
}