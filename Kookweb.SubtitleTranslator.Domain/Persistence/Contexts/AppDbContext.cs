using System.Linq;
using Kookweb.SubtitleTranslator.Domain.Models;
using Kookweb.SubtitleTranslator.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Kookweb.SubtitleTranslator.Domain.Persistence.Contexts {
    public class AppDbContext : DbContext {
        public DbSet<tblTVShow> TVShows { get; set; }
        public DbSet<tblTranslate> Translates { get; set; }
        public DbSet<tblLanguage> Languages { get; set; }
        public DbSet<tblSubtitleFile> SubtitleFile { get; set; }

        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {

            foreach (var entityType in modelBuilder.Model.GetEntityTypes ()
                    .Where (t => t.ClrType.IsSubclassOf (typeof (BaseEntity)))) {
                modelBuilder.Entity (
                    entityType.Name,
                    x => {
                        x.Property ("Created")
                            .HasDefaultValueSql ("getdate()");

                        x.Property ("Modified")
                            .HasDefaultValueSql ("getdate()");

                        x.Property ("IsDeleted")
                            .HasDefaultValue (false);
                    });
            }

            modelBuilder.Entity<tblTVShow> ()
                .HasMany (p => p.Translates)
                .WithOne (b => b.TVShow)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblTranslate> ()
                .HasOne (p => p.SubtitleFile)
                .WithMany (b => b.Translates)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblTranslate> ()
                .HasOne (p => p.TVShow)
                .WithMany (b => b.Translates)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblTranslate> ()
                .HasOne (p => p.Language)
                .WithMany (b => b.Translates)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblLanguage> ()
                .HasMany (p => p.Translates)
                .WithOne (b => b.Language)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblLanguage> ()
                .HasMany (p => p.SubtitleFiles)
                .WithOne (b => b.Language)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblSubtitleFile> ()
                .HasOne (p => p.Language)
                .WithMany (b => b.SubtitleFiles)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<tblSubtitleFile> ()
                .HasMany (p => p.Translates)
                .WithOne (b => b.SubtitleFile)
                .OnDelete (DeleteBehavior.Restrict);

        }
    }
}