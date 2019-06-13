using Kookweb.SubtitleTranslator.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Kookweb.SubtitleTranslator.Domain.Persistence.Contexts {
    public class AppDbContext : DbContext {
        public DbSet<TVShow> TVShows { get; set; }
        public DbSet<Translate> Translates { get; set; }

        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { }
    }
}