using Filmary.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.BLL.Interfaces
{
    public interface IFilmsService
    {
       
        /// <summary>
        /// Add Status
        /// </summary>
        /// <param name="profile">Dto model</param>
        Task AddAsync(Filmsdto film, Profiledto profile, int status);
                        
        Task<IEnumerable<Filmsdto>> GetFilmStatusAsync(int profileId, int Status);

        ///// <summary>
        /////DeleteAsync
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="UserId"></param>
        Task DeleteAsync(Filmsdto film, Profiledto profile);

      
        Task<bool> CheckAddFilm(int id, Profiledto profile);

       
    }
}