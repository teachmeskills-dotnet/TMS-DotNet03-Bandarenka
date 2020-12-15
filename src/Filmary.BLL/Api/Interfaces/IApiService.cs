using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Filmary.BLL.Api.Models;

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