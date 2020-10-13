using Filmary.Common.Interfaces;
using System.Collections.Generic;

namespace Filmary.DAL.Models
{
    public class Genre : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// GenreName
        /// </summary>
        public string GenreName { get; set; }

        /// <summary>
        /// Navigation to GenreFilm
        /// </summary>
        public ICollection<GenreFilm> GenreFilms { get; set; }
    }
}
