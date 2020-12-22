using Filmary.BLL.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.BLL.Api.Interfaces
{
    public interface IApiService
    {
        Task<IEnumerable<Result>> GetResultFilmsAsync(string search);

        Task<IEnumerable<Result>> GetTopFilmsAsync();

        Task<Info> GetInfoFilmsAsync(int id);
    }
}