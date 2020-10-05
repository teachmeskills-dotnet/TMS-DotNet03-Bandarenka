using Filmary.DAL.Configurations;
using Filmary.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Filmary.Common
{
    public class FilmaryDbContext : IdentityDbContext<User>
    {
        public FilmaryDbContext(DbContextOptions<FilmaryDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Profiles
        /// </summary>
        public DbSet<Profile> Profile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new ProfileConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}