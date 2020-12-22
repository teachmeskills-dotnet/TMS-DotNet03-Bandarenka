using Filmary.BLL.Interfaces;
using Filmary.BLL.Models;
using Filmary.Common.Interfaces;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmary.BLL.Services
{
    /// <inheritdoc cref="IFilmsService<T>"/>
    public class FilmsService : IFilmsService
    {
        private readonly IRepository<Films> _repository;
        private readonly IRepository<Status> _repositoryStatus;
        private readonly IRepository<Profile> _repositoryProfile;

        public FilmsService(IRepository<Films> repository, IRepository<Status> repositoryStatus, IRepository<Profile> repositoryProfile)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repositoryStatus = repositoryStatus ?? throw new ArgumentNullException(nameof(repositoryStatus));
            _repositoryProfile = repositoryProfile ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task AddAsync(Filmsdto film, Profiledto profile, int status)
        {
            if (film is null)
            {
                throw new ArgumentNullException(nameof(film));
            }

            var getFilm = await _repository.GetEntityWithoutTrackingAsync(filmid => filmid.FilmsId == film.FilmsId);

            if (getFilm is null)
            {
                var filmmodel = new Films
                {
                    FilmsName = film.FilmsName,
                    FilmsId = film.FilmsId,
                    //  Year = film.Year,
                    //  Scenario = film.Scenario,
                    //  Producer = film.Producer,
                    // Budget = film.Budget,
                    //  Premiere = film.Premiere,
                    Duration = film.Duration,
                    //   Description = film.Description,
                    Picture = film.Picture,
                    //  Rating = film.Rating,
                };

                await _repository.AddAsync(filmmodel);
                await _repository.SaveChangesAsync();
            }

            var getFilmmodel = await _repository.GetEntityWithoutTrackingAsync(filmid => filmid.FilmsId == film.FilmsId);

            var check = await _repositoryStatus.GetEntityAsync(
                checkString => checkString.ProfileId == profile.Id
                && checkString.FilmId == getFilmmodel.Id);

            if (check != null)
            {
                return;
            }

            var filmStatusModel = new Status
            {
                ProfileId = profile.Id,
                FilmId = getFilmmodel.Id,
                StatusName = status,
            };

            await _repositoryStatus.AddAsync(filmStatusModel);
            await _repositoryStatus.SaveChangesAsync();
        }

        public async Task<IEnumerable<Filmsdto>> GetFilmStatusAsync(int profileId, int Status)
        {
            var Filmslist = new List<Filmsdto>();
            var Statuslist = new List<Statusdto>();
            var FilmsUser = await _repositoryStatus
                .GetAll()
                .AsNoTracking()
                .Where(FilmsUser => FilmsUser.ProfileId == profileId && FilmsUser.StatusName == Status)
                .ToListAsync();

            if (!FilmsUser.Any())
            {
                return Filmslist;
            }

            foreach (var FilmsUsers in FilmsUser)
            {
                Statuslist.Add(new Statusdto
                {
                    FilmId = FilmsUsers.FilmId,
                    //Description = transaction.Description,
                    //Comment = transaction.Comment,
                    //Amount = transaction.Amount,
                    //CurrencyType = transaction.CurrencyType,
                    //CreationTime = transaction.CreationTime,
                    //ProfileId = transaction.ProfileId,
                    //GroupId = transaction.GroupId,
                    //Guid = transaction.Guid
                });
            }

            foreach (var filmID in Statuslist)

            {
                var getFilmmodel = await _repository.GetEntityWithoutTrackingAsync(filmid => filmid.Id == filmID.FilmId);
                Filmslist.Add(new Filmsdto
                {
                    FilmsId = getFilmmodel.FilmsId,
                    //Description = transaction.Description,
                    //Comment = transaction.Comment,
                    //Amount = transaction.Amount,
                    //CurrencyType = transaction.CurrencyType,
                    //CreationTime = transaction.CreationTime,
                    //ProfileId = transaction.ProfileId,
                    //GroupId = transaction.GroupId,
                    //Guid = transaction.Guid
                });
            }

            return Filmslist;
        }

        public async Task DeleteAsync(Filmsdto film, Profiledto profile)
        {
            var getFilmmodel = await _repository.GetEntityWithoutTrackingAsync(filmid => filmid.FilmsId == film.FilmsId);

            var delModel = await _repositoryStatus.GetEntityWithoutTrackingAsync(statusModel => statusModel.FilmId == getFilmmodel.Id && statusModel.ProfileId == profile.Id);
            if (delModel is null)
            {
                return;
            }

            _repositoryStatus.Delete(delModel);
            await _repositoryStatus.SaveChangesAsync();
        }

        public async Task<bool> CheckAddFilm(int id, Profiledto profile)
        {
            var getFilmmodel = await _repository.GetEntityWithoutTrackingAsync(filmid => filmid.FilmsId == id);
            if (getFilmmodel is null)
            {
                return false;
            }

            var delModel = await _repositoryStatus.GetEntityWithoutTrackingAsync(statusModel => statusModel.FilmId == getFilmmodel.Id && statusModel.ProfileId == profile.Id);
            if (delModel is null)
            {
                return false;
            }

            return true;
        }
    }
}