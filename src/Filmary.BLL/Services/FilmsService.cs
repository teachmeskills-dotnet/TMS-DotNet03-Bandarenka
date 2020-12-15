
using Filmary.Common.Interfaces;
using Filmary.BLL.Interfaces;
using Filmary.BLL.Models;
using Filmary.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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
                .Where(FilmsUser => FilmsUser.ProfileId == profileId && FilmsUser.StatusName==Status)
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

    }
}









//        public async Task DeleteAsync(Filmsdto film, Profiledto profile, int status)
//        {
//            var getFilmmodel = await _repository
//                .GetEntityAsync(filmid => filmid.FilmsId == film.FilmsId);

//            if (filmid is null)
//            {
//                throw new KeyNotFoundException(ErrorResource.TodoNotFound);
//            }

//            _repository.Delete(todo);
//            await _repositoryTodo.SaveChangesAsync();
//        }














//        public async Task Edit(Filmsdto films)
//        {
//            if (films is null)
//            {
//                throw new ArgumentNullException(nameof(films));
//            }

//            var editFilms = await _repository.GetEntityAsync(q => q.Id.Equals(films.Id));
//            editFilms.FilmsName = films.FilmsName;
//            editFilms.Year = films.Year;
//            editFilms.Scenario = films.Scenario;
//            editFilms.Producer = films.Producer;
//            editFilms.Premiere = films.Premiere;
//            editFilms.Duration = films.Duration;
//            editFilms.Description = films.Description;
//            editFilms.Picture = films.Picture;
//            editFilms.Rating = films.Rating;
//            _repository.Update(editFilms);
//            await _repository.SaveChangesAsync();
//        }

//        public Task<IEnumerable<Filmsdto>> GetFilms(int Id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<Filmsdto> GetFilmsAsync(int id, int FilmsId)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<Filmsdto> GetFilmsAsync(int Id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<Filmsdto> GetFilms(string userId)
//        {
//            if (userId is null)
//            {
//                throw new ArgumentNullException(nameof(userId));
//            }

//            var films = await _repository.GetAll().AsNoTracking().ToListAsync();
//            //var profile = await _profileService.GetProfileByUserId(user.Id);
//            //var filmsdto = await _filmsService.GetFilmsAsync(profile.Id);
//            var filmsDataModel = films.FirstOrDefault(c => c.FilmsName.Equals(userId));
//            if (filmsDataModel is null)
//            {
//                return new Filmsdto();
//            }

//            var film = new Filmsdto
//            {
//                FilmsName = filmsDataModel.FilmsName,
//                Year = filmsDataModel.Year,
//                Scenario = filmsDataModel.Scenario,
//                Producer = filmsDataModel.Producer,
//                Budget = filmsDataModel.Budget,
//                Premiere = filmsDataModel.Premiere,
//                Duration = filmsDataModel.Duration,
//                Description = filmsDataModel.Description,
//                Picture = filmsDataModel.Picture,
//                Rating = filmsDataModel.Rating,

//            };
//            film.Id = filmsDataModel.Id;
//            return film;
//        }

//        public Task<IEnumerable<Filmsdto>> GetFilmsAsync(int FilmsId)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}


