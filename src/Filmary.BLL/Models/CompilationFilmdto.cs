namespace Filmary.BLL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class CompilationFilmdto 
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <inheritdoc/>
        public int CompilationId { get; set; }

        /// <inheritdoc/>
        public int FilmId { get; set; }


    }
}
