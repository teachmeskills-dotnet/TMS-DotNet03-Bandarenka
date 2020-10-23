using Filmary.Common.Interfaces;
using Filmary.BLL.Interfaces;
using Filmary.BLL.Models;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Filmary.BLL.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IRepository<Profile> _repository;

        public ProfileService(IRepository<Profile> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task AddAsync(Profiledto profile)
        {
            if (profile is null)
            {
                throw new ArgumentNullException(nameof(profile));
            }
            var userProfile = new Profile
            {
                UserId = profile.UserId,
                FullName = profile.FullName,

            };

            await _repository.AddAsync(userProfile);
            await _repository.SaveChangesAsync();

        }

        public async Task Edit(Profiledto profile)
        {
            if (profile is null)
            {
                throw new ArgumentNullException(nameof(profile));
            }

            var editProfile = await _repository.GetEntityAsync(q => q.Id.Equals(profile.Id));
            editProfile.FullName = profile.FullName;
            _repository.Update(editProfile);
            await _repository.SaveChangesAsync();
        }

        public async Task<Profiledto> GetProfileByUserId(string userId)
        {
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            var profiles = await _repository.GetAll().AsNoTracking().ToListAsync();
            var profileDataModel = profiles.FirstOrDefault(c => c.UserId.Equals(userId));
            if (profileDataModel is null)
            {
                return new Profiledto();
            }

            var profile = new Profiledto
            {
                UserId = profileDataModel.UserId,
                FullName = profileDataModel.FullName,

            };
            profile.Id = profileDataModel.Id;
            return profile;
        }
    }
}