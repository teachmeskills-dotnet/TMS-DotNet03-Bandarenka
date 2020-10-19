using Filmary.DAL.Configurations;
using Filmary.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Filmary.Context
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

        /// <summary>
        /// Artist
        /// </summary>
        public DbSet<Profile> Artist { get; set; }

        /// <summary>
        /// ArtistFilm
        /// </summary>
        public DbSet<Profile> ArtistFilm { get; set; }

        /// <summary>
        /// Compilation 
        /// </summary>
        public DbSet<Profile> Compilation { get; set; }

        /// <summary>
        /// CompilationFilm
        /// </summary>
        public DbSet<Profile> CompilationFilm { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public DbSet<Profile> Country { get; set; }

        /// <summary>
        /// CountryFilm
        /// </summary>
        public DbSet<Profile> CountryFilm { get; set; }

        /// <summary>
        /// Films
        /// </summary>
        public DbSet<Profile> Films { get; set; }

        /// <summary>
        /// Genre
        /// </summary>
        public DbSet<Profile> Genre { get; set; }

        /// <summary>
        /// GenreFilm
        /// </summary>
        public DbSet<Profile> GenreFilm { get; set; }

        /// <summary>
        /// Producer
        /// </summary>
        public DbSet<Profile> Producer { get; set; }

        /// <summary>
        /// ProducerFilm
        /// </summary>
        public DbSet<Profile> ProducerFilm { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public DbSet<Profile> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistFilmConfiguration());
            modelBuilder.ApplyConfiguration(new CompilationConfiguration());
            modelBuilder.ApplyConfiguration(new CompilationFilmConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CountryFilmConfiguration());
            modelBuilder.ApplyConfiguration(new FilmsConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new GenreFilmConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerFilmConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}