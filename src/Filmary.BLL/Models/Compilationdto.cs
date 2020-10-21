namespace Filmary.BLL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class Compilationdto
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string CompilationName { get; set; }

        /// <summary>
        /// ProfileId
        /// </summary>
        public int ProfileId { get; set; }

    }
}
