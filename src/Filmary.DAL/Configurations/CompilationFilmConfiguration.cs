using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for Compilation entity.
    /// </summary>
    public class CompilationFilmConfiguration : IEntityTypeConfiguration<CompilationFilm>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<CompilationFilm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.CompilationFilm)
                .HasKey(CompilationFilm => CompilationFilm.Id);


            builder.HasOne(CompilationFilm => CompilationFilm.Compilation)
               .WithMany(Compilation => Compilation.CompilationFilms)
               .HasForeignKey(CompilationFilm => CompilationFilm.CompilationId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(CompilationFilm => CompilationFilm.Films)
               .WithMany(Films => Films.CompilationFilms)
               .HasForeignKey(CompilationFilm => CompilationFilm.FilmId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}