using System;
using System.Collections.Generic;
using System.Text;

namespace Filmary.BLL.Api.Models
{
   
    public class Example
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public IList<Result> results { get; set; }
    }
}
