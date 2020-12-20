using Filmary.BLL.Api.Interfaces;
using Filmary.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmary.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiService _IApiService;

        public HomeController(IApiService apiService)
        {
            _IApiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
        }

        public async Task<IActionResult> Index()
        {
            var topFilms = await _IApiService.GetTopFilmsAsync();
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
    }
}