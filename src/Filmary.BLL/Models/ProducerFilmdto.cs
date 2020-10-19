using Filmary.Common.Interfaces;

namespace Filmary.DAL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class ProducerFilmdto
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Producer identifier.
        /// </summary>
        public int ProducerId { get; set; }
               
        /// <summary>
        /// Films identifier.
        /// </summary>
        public int FilmId { get; set; }


    }
}