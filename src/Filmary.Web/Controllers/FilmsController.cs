using Filmary.BLL.Api.Interfaces;
using Filmary.BLL.Interfaces;
using Filmary.BLL.Models;
using Filmary.DAL.Models;
using Filmary.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

                //if (FilmsWeek.poster_path == null)
                //{
                //    pic = @"file:///D:/TMS-DotNet03-Bandarenka/src/Filmary.Web/wwwroot/img/no_poster.jpg";
                //}
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
            var FilmInfo = await _IApiService.GetInfoFilmsAsync(ID);
            var pic = "https://image.tmdb.org/t/p/w500" + FilmInfo.poster_path;
            var FilmInfoModel = new FilmsViewModel
            {

                FilmsName = FilmInfo.title,
                Duration = FilmInfo.overview,
                //Premiere = FilmInfo.release_date,
                Budget = FilmInfo.budget,
                Picture = pic,
                Id = ID

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











        ///// <summary>
        ///// Change Film model
        ///// </summary>
        ///// <returns>User model</returns>
        //public async Task<IActionResult> EditFilms()
        //{
        //    var username = User.Identity.Name;
        //    var user = await _userManager.FindByNameAsync(username);
        //    var profile = await _profileService.GetProfileByUserId(user.Id);
        //    var filmsdto = await _filmsService.GetFilmsAsync(profile.Id);


        //    //var model = new FilmsViewModel { 
        //    var filmsViewsModels = new List<FilmsViewModel>();

        //    foreach (var Filmsdto in filmsdto)
        //    {
        //        filmsViewsModels.Add(new FilmsViewModel
        //        {

        //            FilmsName = filmsdto.FilmsName, 
        //            Year = filmsdto.Year, 
        //            Scenario = filmsdto.Scenario, 
        //            Producer = filmsdto.Producer, 
        //            Budget = filmsdto.Budget, 
        //            Premiere = filmsdto.Premiere, 
        //            Duration = filmsdto.Duration,
        //            Description = filmsdto.Description, 
        //            Picture = filmsdto.Picture, 
        //            Rating = filmsdto.Rating 
        //        });
        //    }
        //    return View(filmsViewsModels);
        //}


        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}


        /// <summary>
        /// Edit editFilms
        /// </summary>
        /// <param name="editFilms"></param>
        /// <returns>Result edit films</returns>
        //[Authorize]
        //[HttpPost]

        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> EditFilms(FilmsViewModel editFilms)
        //{
        //    var username = User.Identity.Name;
        //    var user = await _userManager.FindByNameAsync(username);
        //    var profile = await _profileService.GetProfileByUserId(user.Id);
        //    var filmsdto = await _filmsService.GetFilmsAsync(profile.Id);

        //    var films = new Filmsdto
        //    {
        //        Id = filmsdto.Id,
        //        FilmsName = filmsdto.FilmsName,
        //        Year = filmsdto.Year,
        //        Scenario = filmsdto.Scenario,
        //        Producer = filmsdto.Producer,
        //        Budget = filmsdto.Budget,
        //        Premiere = filmsdto.Premiere,
        //        Duration = filmsdto.Duration,
        //        Description = filmsdto.Description,
        //        Picture = filmsdto.Picture,
        //        Rating = filmsdto.Rating,
        //    };

        //    await _filmsService.Edit(films);
        //    return RedirectToAction("Films");
        // }



    }
}

