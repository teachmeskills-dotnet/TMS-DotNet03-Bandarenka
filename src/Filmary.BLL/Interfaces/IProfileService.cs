using Filmary.BLL.Models;
using System.Threading.Tasks;

namespace Filmary.BLL.Interfaces
{
    public interface IProfileService
    {
        Task AddAsync(Profiledto profile);

        Task Edit(Profiledto profile);

        Task<Profiledto> GetProfileByUserId(string userId);
    }
}