using Filmary.BLL.Api.Services;
using System;

namespace TMS.Nbrb.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
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