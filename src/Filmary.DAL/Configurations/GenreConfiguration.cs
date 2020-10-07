using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for Genre entity.
    /// </summary>
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Genre)
                .HasKey(Genre => Genre.Id);


            builder.Property(Genre => Genre.GenreName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

        }
    }
}