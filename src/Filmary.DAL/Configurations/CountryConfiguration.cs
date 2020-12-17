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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Country)
                .HasKey(Country => Country.Id);

            builder.Property(Country => Country.CountryName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);
        }
    }
}