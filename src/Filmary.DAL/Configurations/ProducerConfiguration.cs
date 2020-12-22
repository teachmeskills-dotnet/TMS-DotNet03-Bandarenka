using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for Producer entity.
    /// </summary>
    public class ProducerConfiguration : IEntityTypeConfiguration<Producer>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Producer> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Producer)
                .HasKey(Producer => Producer.Id);

            builder.Property(Producer => Producer.ProducerName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);
        }
    }
}