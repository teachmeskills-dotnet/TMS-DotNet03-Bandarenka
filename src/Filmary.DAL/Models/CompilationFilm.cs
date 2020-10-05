using Filmary.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Models
{
    public class CompilationFilm : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }
        /// <inheritdoc/>
        public string CompilationId { get; set; }

        /// <summary>
        /// Navigation to Compilation
        /// </summary>
        public Compilation Compilation { get; set; }

        /// <inheritdoc/>
        public string FilmId { get; set; }

        /// <summary>
        /// Navigation to Films
        /// </summary>
        public Films Films { get; set; }
    }
}
