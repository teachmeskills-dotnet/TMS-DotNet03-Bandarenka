using Filmary.BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.BLL.Interfaces
{
    public interface IFilmsService
    {
        ///// <summary>
        ///// Add films 
        ///// </summary>
        ///// <param name="films">Dto model</param>
        //Task AddAsync(Filmsdto films);


        ///// <summary>
        ///// Edit films
        ///// </summary>
        ///// <param name="profile">Dto model</param>
        //Task Edit(Filmsdto films);



        ///// <summary>
        ///// Get Films
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="filmsId"></param>

        //Task<Filmsdto> GetFilmsAsync(int Id);

        ///// <summary>
        ///// Get Films from base
        ///// </summary>
        ///// <param name="userId">Search profil by UserId key</param>
        //Task<IEnumerable<Filmsdto>> GetFilms(int Id);

        /// <summary>
        /// Add Status
        /// </summary>
        /// <param name="profile">Dto model</param>
        Task AddAsync(Filmsdto film, Profiledto profile, int status);

        /// <summary>
        /// Edit Compilation
        /// </summary>
        /// <param name="Compilation">Dto model</param>
        //Task DeleteAsync(Filmsdto film, Profiledto profile, int status);





        /// <summary>
        /// Edit Compilation
        /// </summary>
        /// <param name="Compilation">Dto model</param>
        Task<IEnumerable<Filmsdto>> GetFilmStatusAsync(int profileId, int Status);

        ///// <summary>
        /////DeleteAsync
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="UserId"></param>
         Task DeleteAsync(Filmsdto film, Profiledto profile);

        ///// <summary>
        ///// Get Compilation from base
        ///// </summary>
        ///// <param name="userId">Search profil by UserId key</param>
        Task<bool> CheckAddFilm(int id, Profiledto profile);

        //Task AddAsyncStatusProfile(Statusdto StatusFilms);

        ///// <summary>
        ///// Get compilation by Guid
        ///// </summary>
        ///// <param name="guid"></param>
        ///// <returns>GroupDto</returns>
        //Task<Statusdto> GetStatusByGuidAsync(int status);

    }
}