using Filmary.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Models
{
    public class Status : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// ProfileId identifier.
        /// </summary>
        public int ProfileId { get; set; }

        /// <summary>
        /// Navigation to Artist.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// FilmId identifier.
        /// </summary>
        public int FilmId { get; set; }

        /// <summary>
        /// Navigation to Films.
        /// </summary>
        public Films Films { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        public int StatusName { get; set; }
    }
}
