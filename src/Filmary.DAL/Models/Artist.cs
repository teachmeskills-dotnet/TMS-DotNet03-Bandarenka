using Filmary.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Models
{
    public class Artist : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// ArtistName
        /// </summary>
        public string ArtistName { get; set; }

        /// <summary>
        /// Navigation to ArtistFilm
        /// </summary>
        public ICollection<ArtistFilm> ArtistFilms { get; set; }
    }
}
