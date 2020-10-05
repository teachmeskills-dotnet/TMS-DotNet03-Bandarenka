using Filmary.Common.Interfaces;

namespace Filmary.DAL.Models
{
    public class GenreFilm : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Genre identifier.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Navigation to Genre.
        /// </summary>
        public Genre Genre { get; set; }

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