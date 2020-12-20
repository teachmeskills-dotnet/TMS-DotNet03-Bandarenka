using Filmary.BLL.Api.Helpers;
using Filmary.BLL.Api.Interfaces;
using Filmary.BLL.Api.Models;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.BLL.Api.Services

{
    /// <inheritdoc cref="IApiService"/>
    public class ApiService : IApiService
    {
        public async Task<IEnumerable<Result>> GetResultFilmsAsync(string search)
        {
            var response = await Constants.searchFilmByName
               .SetQueryParams(new { api_key = "85a8787fd5a554d0bc0d4c24198e2702", language = "ru", query = search })
               .GetJsonAsync<Example>();
            var films = response.results;
            return films;
        }

        public async Task<IEnumerable<Result>> GetTopFilmsAsync()
        {
            var response = await Constants.topFilms
               .SetQueryParams(new { api_key = "85a8787fd5a554d0bc0d4c24198e2702", language = "ru" })
               .GetJsonAsync<Example>();
            var films = response.results;
            return films;
        }

        public async Task<Info> GetInfoFilmsAsync(int id)

        {
            string info = Constants.InfoFilm + id;
            var response = await info
               .SetQueryParams(new { api_key = "85a8787fd5a554d0bc0d4c24198e2702", language = "ru" })
               .GetJsonAsync<Info>();

            return response;
        }
    }
}