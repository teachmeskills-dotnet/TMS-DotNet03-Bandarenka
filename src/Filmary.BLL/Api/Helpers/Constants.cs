using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.BLL.Api.Helpers
{
    class Constants
    {
        /// <summary>
        /// Поиск по названию.
        /// </summary>
       //public const string searchFilmByName = "https://api.themoviedb.org/3/search/multi?api_key=85a8787fd5a554d0bc0d4c24198e2702&language=ru";
        public const string searchFilmByName = "https://api.themoviedb.org/3/search/multi";
        public const string  topFilms = "https://api.themoviedb.org/3/trending/all/week";
        public const string InfoFilm = "https://api.themoviedb.org/3/movie/";

    }
}