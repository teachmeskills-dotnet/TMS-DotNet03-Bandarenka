using Filmary.BLL.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.BLL.Api.Interfaces
{
    public interface IApiService
    {
        /// <summary>
        /// Поиск по названию фильма
        /// </summary>
        /// <param name="searchFilmByName"></param>
        /// <returns>List films</returns>
        //public Task<List<Result>> GetResultFilmsAsync(string FilmByName);
        Task<IEnumerable<Result>> GetResultFilmsAsync(string search);

        Task<IEnumerable<Result>> GetTopFilmsAsync();

        Task<Info> GetInfoFilmsAsync(int id);
    }
}