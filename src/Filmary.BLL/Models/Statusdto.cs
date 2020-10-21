namespace Filmary.BLL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class Statusdto
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// ProfileId identifier.
        /// </summary>
        public int ProfileId { get; set; }


        /// <summary>
        /// FilmId identifier.
        /// </summary>
        public int FilmId { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        public int StatusName { get; set; }
    }
}
