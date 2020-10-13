using Filmary.Common.Interfaces;

namespace Filmary.DAL.Models
{
    public class CountryFilm : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Country identifier.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Navigation to Country.
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Films identifier.
        /// </summary>
        public int FilmId { get; set; }

        /// <summary>
        /// Navigation to Films.
        /// </summary>
        public Films Films { get; set; }

    }
}
