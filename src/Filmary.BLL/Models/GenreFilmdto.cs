namespace Filmary.BLL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class GenreFilmdto
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Genre identifier.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Films identifier.
        /// </summary>
        public int FilmId { get; set; }
    }
}