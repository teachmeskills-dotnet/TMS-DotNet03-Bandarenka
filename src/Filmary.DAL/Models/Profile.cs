using Filmary.Common.Interfaces;
using System.Collections.Generic;

namespace Filmary.DAL.Models
{ /// <summary>
  /// Profile
  /// </summary>
    public class Profile : IHasDbIdentity, IHasUserIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

        /// <summary>
        /// Navigation to User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// FullName
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Navigation to Compilation
        /// </summary>
        public ICollection<Compilation> Compilations { get; set; }

        /// <summary>
        /// Navigation to Status
        /// </summary>
        public ICollection<Status> Statuses { get; set; }
    }
}