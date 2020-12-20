namespace Filmary.BLL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class CountryFilmdto
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

        public int FilmId { get; set; }
    }
}