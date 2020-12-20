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
    public class ProducerFilmConfiguration : IEntityTypeConfiguration<ProducerFilm>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ProducerFilm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.ProducerFilm)
                .HasKey(ProducerFilm => ProducerFilm.Id);

            builder.HasOne(ProducerFilm => ProducerFilm.Producer)
               .WithMany(Producer => Producer.ProducerFilms)
               .HasForeignKey(ProducerFilm => ProducerFilm.ProducerId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ProducerFilm => ProducerFilm.Films)
               .WithMany(Films => Films.ProducerFilms)
               .HasForeignKey(ProducerFilm => ProducerFilm.FilmId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}