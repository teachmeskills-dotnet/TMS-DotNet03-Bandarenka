using Filmary.Common.Interfaces;
using System.Collections.Generic;

namespace Filmary.DAL.Models
{
    public class Compilation : IHasDbIdentity
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

        /// <summary>
        /// Navigation to Profile.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Navigation to CompilationFilm
        /// </summary>
        public ICollection<CompilationFilm> CompilationFilms { get; set; }
    }
}