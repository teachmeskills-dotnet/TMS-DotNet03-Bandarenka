using Filmary.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.DAL.Models
{
    public class Producer : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// ProducerName
        /// </summary>
        public string ProducerName { get; set; }

        /// <summary>
        /// Navigation to ProducerFilm
        /// </summary>
        public ICollection<ProducerFilm> ProducerFilms { get; set; }
    }
}
