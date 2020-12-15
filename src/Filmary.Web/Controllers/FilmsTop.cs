//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Flurl.Http;
//using Filmary.BLL.Api.Interfaces;
//using Filmary.BLL.Api.Services;
//using Filmary.BLL.Api.Models;

//using Flurl;
//using Filmary.Web.ViewModels;

//namespace Filmary.Web.Controllers
//{
//    public class FilmsTop : Controller
//    {
//        public IActionResult Index()
//        {
//            ApiService service = new ApiService();
//            return View();
//        }

//        public IActionResult Index()
//        {
//            ApiService service = new ApiService();




//            var result = service.GetResultFilmsAsync().GetAwaiter().GetResult();


//            foreach (var films in result)
//            {
//                FilmsViewModel.Add(new FilmsViewModel
//                {
//                    Id = films.Id,
//                    FilmsName = films.FilmsName,
//                    Description = films.Description;

//            return View(todoViewModels);
//            }

//        }
//    }
//}
