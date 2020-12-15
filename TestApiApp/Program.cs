using Flurl.Http;
using System;
using Filmary.BLL.Api.Interfaces;
using Filmary.BLL.Api.Services;
using Filmary.BLL.Api.Models;
using System.Threading.Tasks;
using Flurl;

namespace TMS.Nbrb.ConsoleApp
{
    class Program
  {
        static void Main(string[] args)
        {

            ApiService service = new ApiService();




            var result = service.GetInfoFilmsAsync(577922).GetAwaiter().GetResult();



            //foreach (var films in result)
            //{
            //    Console.WriteLine($"Name:{films.original_title}");
            //}
            //Console.ReadLine();
            Console.WriteLine($"Name:{result.original_title}");

        }


    }
    }
