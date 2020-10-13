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
    public class CountryFilmConfiguration : IEntityTypeConfiguration<CountryFilm>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<CountryFilm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.CountryFilm)
                .HasKey(CountryFilm => CountryFilm.Id);


            builder.HasOne(CountryFilm => CountryFilm.Country)
               .WithMany(Country => Country.CountryFilms)
               .HasForeignKey(CountryFilm => CountryFilm.CountryId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(CountryFilm => CountryFilm.Films)
               .WithMany(Films => Films.CountryFilms)
               .HasForeignKey(CountryFilms => CountryFilms.FilmId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}