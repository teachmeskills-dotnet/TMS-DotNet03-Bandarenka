using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for Artist entity.
    /// </summary>
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Artist)
                .HasKey(Artist => Artist.Id);

            
            builder.Property(Artist => Artist.ArtistName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

        }
    }
}