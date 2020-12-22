using Filmary.BLL.Models;
using System.Threading.Tasks;

namespace Filmary.BLL.Interfaces
{
    /// <summary>
    /// Service from controle user profile
    /// </summary>
    public interface IProfileService
    {
        /// <summary>
        /// Add profile from user identity
        /// </summary>
        /// <param name="profile">Dto model</param>
        Task AddAsync(Profiledto profile);

        /// <summary>
        /// Edit profile
        /// </summary>
        /// <param name="profile">Dto model</param>
        Task Edit(Profiledto profile);

        /// <summary>
        /// Get profile from base
        /// </summary>
        /// <param name="userId">Search profil by UserId key</param>
        Task<Profiledto> GetProfileByUserId(string userId);
    }
}