using Microsoft.AspNetCore.Identity;

namespace Filmary.DAL.Models
{
    /// <summary>
    /// Object of application user.
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Navigation to User
        /// </summary>
        public Profile Profile { get; set; }
    }
}