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
    public class CompilationConfiguration : IEntityTypeConfiguration<Compilation>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Compilation> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Compilation)
                .HasKey(Compilation => Compilation.Id);


            builder.Property(Compilation => Compilation.CompilationName)                
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.HasOne(Compilation => Compilation.Profile)
               .WithMany(Profile => Profile.Compilations)
               .HasForeignKey(Compilation => Compilation.ProfileId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}