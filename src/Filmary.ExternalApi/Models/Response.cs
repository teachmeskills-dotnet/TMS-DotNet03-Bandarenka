using System.Collections.Generic;

namespace Filmary.ExternalApi.Models
{
    public class Response
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public IList<Result> results { get; set; }
    }
}