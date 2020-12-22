using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for ArtistFilm entity.
    /// </summary>
    public class ArtistFilmConfiguration : IEntityTypeConfiguration<ArtistFilm>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ArtistFilm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.ArtistFilm)
                .HasKey(ArtistFilm => ArtistFilm.Id);

            builder.HasOne(ArtistFilm => ArtistFilm.Artist)
               .WithMany(Artist => Artist.ArtistFilms)
               .HasForeignKey(ArtistFilm => ArtistFilm.ArtistId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ArtistFilm => ArtistFilm.Films)
               .WithMany(Films => Films.ArtistFilms)
               .HasForeignKey(ArtistFilms => ArtistFilms.FilmId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}