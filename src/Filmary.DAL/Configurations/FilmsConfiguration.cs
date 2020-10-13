using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for Films entity.
    /// </summary>
    public class FilmsConfiguration : IEntityTypeConfiguration<Films>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Films> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Films)
                .HasKey(Films => Films.Id);

       
            builder.Property(Films => Films.Year)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Scenario)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Producer)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Budget)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Premiere)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Duration)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Description)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Picture)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.FilmsName)
                .IsRequired()
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.Property(Films => Films.Rating)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

        }
    }
}