using Kookweb.SubtitleTranslator.Domain.Persistence.Contexts;

namespace Kookweb.SubtitleTranslator.Domain.Repositories {
    public class BaseRepository {
        protected readonly AppDbContext _context;

        public BaseRepository (AppDbContext context) {
            _context = context;
        }
    }
}