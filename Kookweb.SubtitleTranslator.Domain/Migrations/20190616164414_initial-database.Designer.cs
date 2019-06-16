﻿// <auto-generated />
using System;
using Kookweb.SubtitleTranslator.Domain.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kookweb.SubtitleTranslator.Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190616164414_initial-database")]
    partial class initialdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kookweb.SubtitleTranslator.Domain.Models.tblLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Kookweb.SubtitleTranslator.Domain.Models.tblSubtitleFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("FilePath");

                    b.Property<int>("LanguageId");

                    b.Property<DateTime>("Modified");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("SubtitleFile");
                });

            modelBuilder.Entity("Kookweb.SubtitleTranslator.Domain.Models.tblTVShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<byte>("ShowType");

                    b.HasKey("Id");

                    b.ToTable("TVShows");
                });

            modelBuilder.Entity("Kookweb.SubtitleTranslator.Domain.Models.tblTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("Episode");

                    b.Property<int>("LanguageId");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("Season");

                    b.Property<int>("SubtitleFileId");

                    b.Property<int>("TVShowId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("SubtitleFileId");

                    b.HasIndex("TVShowId");

                    b.ToTable("Translates");
                });

            modelBuilder.Entity("Kookweb.SubtitleTranslator.Domain.Models.tblSubtitleFile", b =>
                {
                    b.HasOne("Kookweb.SubtitleTranslator.Domain.Models.tblLanguage", "Language")
                        .WithMany("SubtitleFiles")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Kookweb.SubtitleTranslator.Domain.Models.tblTranslate", b =>
                {
                    b.HasOne("Kookweb.SubtitleTranslator.Domain.Models.tblLanguage", "Language")
                        .WithMany("Translates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Kookweb.SubtitleTranslator.Domain.Models.tblSubtitleFile", "SubtitleFile")
                        .WithMany("Translates")
                        .HasForeignKey("SubtitleFileId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Kookweb.SubtitleTranslator.Domain.Models.tblTVShow", "TVShow")
                        .WithMany("Translates")
                        .HasForeignKey("TVShowId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}