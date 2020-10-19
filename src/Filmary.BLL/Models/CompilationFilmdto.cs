using Filmary.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Models
{
    /// <summary>
    /// Transport model from groupeprofile
    /// </summary>
    public class CompilationFilmdto : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <inheritdoc/>
        public int CompilationId { get; set; }

        /// <summary>
        /// Navigation to Compilation
        /// </summary>
        public Compilationdto Compilation { get; set; }

        /// <inheritdoc/>
        public int FilmId { get; set; }

        /// <summary>
        /// Navigation to Films
        /// </summary>
        public Filmsdto Films { get; set; }
    }
}
