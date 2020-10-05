using Filmary.Common.Interfaces;
using System.Collections.Generic;

namespace Filmary.DAL.Models
{
    public class Films : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// FilmsName
        /// </summary>
        public string FilmsName { get; set; }

        /// <summary>
        /// Year
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// Scenario
        /// </summary>
        public string Scenario { get; set; }

        /// <summary>
        /// Producer
        /// </summary>
        public string Producer { get; set; }

        /// <summary>
        /// Budget
        /// </summary>
        public string Budget { get; set; }

        /// <summary>
        /// Premiere
        /// </summary>
        public string Premiere { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Picture
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        /// Navigation to CountryFilm
        /// </summary>
        public ICollection<CountryFilm> CountryFilms { get; set; }

        /// <summary>
        /// Navigation to CountryFilm
        /// </summary>
        public ICollection<ArtistFilm> ArtistFilms { get; set; }

        /// <summary>
        /// Navigation to CountryFilm
        /// </summary>
        public ICollection<GenreFilm> GenreFilms { get; set; }

        /// <summary>
        /// Navigation to CountryFilm
        /// </summary>
        public ICollection<ProducerFilm> ProducerFilms { get; set; }

        /// <summary>
        /// Navigation to CompilationFilm
        /// </summary>
        public ICollection<CompilationFilm> CompilationFilms { get; set; }

        /// <summary>
        /// Navigation to Status
        /// </summary>
        public ICollection<Status> Statuses { get; set; }




    }
}
