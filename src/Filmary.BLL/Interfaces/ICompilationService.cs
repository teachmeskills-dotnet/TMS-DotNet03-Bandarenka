
using Filmary.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICompilationService.BLL.Interfaces
{
    public interface ICompilationService
    {
        /// <summary>
        /// Add Compilation
        /// </summary>
        /// <param name="profile">Dto model</param>
        Task AddAsync(Compilationdto Compilation);

        /// <summary>
        /// Edit Compilation
        /// </summary>
        /// <param name="Compilation">Dto model</param>
        Task Edit(Compilationdto Compilation);

        /// <summary>
        /// Get Compilation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UserId"></param>
        Task<Compilationdto> GetCompilationAsync(int id, int profileId);
        /// <summary>
        /// Get Compilation from base
        /// </summary>
        /// <param name="userId">Search profil by UserId key</param>
        Task<IEnumerable<Compilationdto>> GetCompilation(int profileId);

        Task AddAsyncCompilationProfile(CompilationFilmdto compilationFilms);
    }
}