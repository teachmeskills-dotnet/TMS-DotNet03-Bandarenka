using Filmary.BLL.Api.Interfaces;
using Filmary.BLL.Interfaces;
using Filmary.BLL.Models;
using Filmary.DAL.Models;
using Filmary.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.Web.Controllers
{
    public class FilmsController : Controller
    {
        private readonly UserManager<User> _userManager;

        // private readonly IFilmsService _filmsService;
        private readonly IProfileService _profileService;

        private readonly IApiService _IApiService;
        private readonly IFilmsService _filmsService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        /// <param name="profileService"></param>
        public FilmsController(UserManager<User> userManager, IProfileService profileService, IApiService apiService, IFilmsService filmsService)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _profileService = profileService ?? throw new ArgumentNullException(nameof(profileService));
            _filmsService = filmsService ?? throw new ArgumentNullException(nameof(filmsService));
            _IApiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
        }

        [HttpPost]
        public async Task<IActionResult> SearchFilms(string search)
        {
            var topFilms = await _IApiService.GetResultFilmsAsync(search);
            var FilmsTopViewsModels = new List<HomeViewModel>();

            foreach (var FilmsWeek in topFilms)
            {
                var pic = "https://image.tmdb.org/t/p/w500" + FilmsWeek.poster_path;

                if (FilmsWeek.poster_path == null)
                {
                    pic = "/img/noposter.jpg";
                }
                if (FilmsWeek.name != null)
                {
                    FilmsTopViewsModels.Add(new HomeViewModel
                    {
                        FilmsName = FilmsWeek.name,
                        Picture = pic,
                        ID = FilmsWeek.id
                    });
                }
                else
                {
                    FilmsTopViewsModels.Add(new HomeViewModel
                    {
                        FilmsName = FilmsWeek.title,
                        Picture = pic,
                        ID = FilmsWeek.id
                    });
                }
            }
            return View(FilmsTopViewsModels);
        }

        public async Task<IActionResult> FilmsInfo(int ID)

        {
            var status = false;
            var username = User.Identity.Name;
            if (username != null)
            {
                var user = await _userManager.FindByNameAsync(username);
                var profile = await _profileService.GetProfileByUserId(user.Id);
                status = await _filmsService.CheckAddFilm(ID, profile);
            }

            var FilmInfo = await _IApiService.GetInfoFilmsAsync(ID);
            var pic = "https://image.tmdb.org/t/p/w500" + FilmInfo.poster_path;
            if (FilmInfo.poster_path == null)
            {
                pic = "/img/noposter.jpg";
            }
            var FilmInfoModel = new FilmsViewModel
            {
                FilmsName = FilmInfo.title,
                Duration = FilmInfo.overview,
                //Premiere = FilmInfo.release_date,
                Budget = FilmInfo.budget,
                Picture = pic,
                Id = ID,
                Button = status
            };

            return View(FilmInfoModel);
        }

        public async Task<IActionResult> FilmsAdd(int ID, int status)
        {
            var username = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(username);
            var profile = await _profileService.GetProfileByUserId(user.Id);
            var Filmsdto = await _IApiService.GetInfoFilmsAsync(ID);

            var model = new Filmsdto
            {
                FilmsName = Filmsdto.title,
                FilmsId = Filmsdto.id
                //Premiere = FilmInfo.release_date,

                //FilmsName = Filmsdto.FilmsName,
                //Year = filmsdto.Year,
                //Scenario = filmsdto.Scenario,
                //Producer = filmsdto.Producer,
                //Budget = filmsdto.Budget,
                //Premiere = filmsdto.Premiere,
                //Duration = filmsdto.Duration,
                //Description = filmsdto.Description,
                //Picture = filmsdto.Picture,
                //Rating = filmsdto.Rating
            };

            await _filmsService.AddAsync(model, profile, status);

            return RedirectToAction("FilmsInfo", "Films", new { id = ID });
        }

        public async Task<IActionResult> FilmsWatchedStatus(int status)
        {
            var username = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(username);
            var profile = await _profileService.GetProfileByUserId(user.Id);
            var Filmsdto = await _filmsService.GetFilmStatusAsync(profile.Id, status);

            var filmsViewsModels = new List<FilmsViewModel>();

            foreach (var filmsApi in Filmsdto)
            {
                var ApiFilmsView = await _IApiService.GetInfoFilmsAsync(filmsApi.FilmsId);
                var pic = "https://image.tmdb.org/t/p/w500" + ApiFilmsView.poster_path;
                if (ApiFilmsView.poster_path == null)
                {
                    pic = "/img/noposter.jpg";
                }
                filmsViewsModels.Add(new FilmsViewModel
                {
                    Id = filmsApi.FilmsId,
                    FilmsName = ApiFilmsView.title,
                    //Duration = ApiFilmsView.Duration,
                    Picture = pic
                });
            }
            return View(filmsViewsModels);
        }

        public async Task<IActionResult> FilmsDel(int ID)
        {
            var username = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(username);
            var profile = await _profileService.GetProfileByUserId(user.Id);
            var Filmsdto = await _IApiService.GetInfoFilmsAsync(ID);

            var model = new Filmsdto
            {
                FilmsName = Filmsdto.title,
                FilmsId = Filmsdto.id
            };

            await _filmsService.DeleteAsync(model, profile);

            return RedirectToAction("FilmsInfo", "Films", new { id = ID });
        }
    }
}