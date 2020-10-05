using Filmary.Common.Interfaces;

namespace Filmary.DAL.Models
{
    public class ArtistFilm : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Artist identifier.
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// Navigation to Artist.
        /// </summary>
        public Artist Artist { get; set; }

        /// <summary>
        /// Films identifier.
        /// </summary>
        public int FilmsId { get; set; }

        /// <summary>
        /// Navigation to Films.
        /// </summary>
        public Films Films { get; set; }

    }
}