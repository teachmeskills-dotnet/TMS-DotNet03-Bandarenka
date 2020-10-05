using Filmary.Common.Interfaces;

namespace Filmary.DAL.Models
{
    public class ProducerFilm : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Producer identifier.
        /// </summary>
        public int ProducerId { get; set; }

        /// <summary>
        /// Navigation to Producer.
        /// </summary>
        public Producer Producer { get; set; }

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