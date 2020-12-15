using System;

namespace Filmary.Web.ViewModels
{
    public class FilmsViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// FilmsName
        /// </summary>
        public string FilmsName { get; set; }

        /// <summary>
        /// Year
        /// </summary>
        public DateTime Year { get; set; }

        /// <summary>
        /// Scenario
        /// </summary>
        public string Scenario { get; set; }

        /// <summary>
        /// Producer
        /// </summary>
        public string Producer { get; set; }

        /// <summary>
        /// Budget
        /// </summary>
        public int Budget { get; set; }

        /// <summary>
        /// Premiere
        /// </summary>
        public DateTime Premiere { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Picture
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public bool Button { get; set; }

    }
}

