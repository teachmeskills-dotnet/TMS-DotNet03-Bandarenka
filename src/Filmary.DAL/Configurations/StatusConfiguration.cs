
using Filmary.Common.Contants;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Filmary.DAL.Configurations
{
    /// <summary>
    /// EF Configuration for Status entity.
    /// </summary>
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TableConstants.Status)
                .HasKey(Status => Status.Id);


            builder.Property(Status => Status.StatusName)
                .HasMaxLength(ConfigurationContants.SqlMaxLengthMedium);

            builder.HasOne(Status => Status.Profile)
               .WithMany(Profile => Profile.Statuses)
               .HasForeignKey(Compilation => Compilation.ProfileId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(Status => Status.Films)
               .WithMany(Films => Films.Statuses)
               .HasForeignKey(Status => Status.FilmId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}