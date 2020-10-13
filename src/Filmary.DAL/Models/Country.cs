using Filmary.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Models
{
    public class Country : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// CountryName
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Navigation to CountryFilm
        /// </summary>
        public ICollection<CountryFilm> CountryFilms { get; set; }
    }
}
