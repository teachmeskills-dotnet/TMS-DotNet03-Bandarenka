using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for GenreFilm entity.
    /// </summary>
    public class GenreFilmConfiguration : IEntityTypeConfiguration<GenreFilm>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<GenreFilm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.GenreFilm)
                .HasKey(GenreFilm => GenreFilm.Id);

            builder.HasOne(GenreFilm => GenreFilm.Genre)
               .WithMany(Genre => Genre.GenreFilms)
               .HasForeignKey(GenreFilm => GenreFilm.GenreId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(GenreFilm => GenreFilm.Films)
             .WithMany(Films => Films.GenreFilms)
             .HasForeignKey(GenreFilms => GenreFilms.FilmId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}