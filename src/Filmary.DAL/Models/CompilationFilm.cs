using Filmary.Common.Interfaces;

namespace Filmary.DAL.Models
{
    public class CompilationFilm : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public int CompilationId { get; set; }

        /// <summary>
        /// Navigation to Compilation
        /// </summary>
        public Compilation Compilation { get; set; }

        /// <inheritdoc/>
        public int FilmId { get; set; }

        /// <summary>
        /// Navigation to Films
        /// </summary>
        public Films Films { get; set; }
    }
}