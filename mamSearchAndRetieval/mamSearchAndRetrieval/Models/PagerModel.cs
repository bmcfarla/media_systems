using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mamSearchAndRetrieval.Models
{
    public class PagerModel
    {
        public decimal pages  { get; set; }
        public int startPage { get; set; }
        public int firstHit { get; set; }
        public int maxHits { get; set; }
        public int hitsPerPage { get; set; }
        public int totalRecords { get; set; }
    }
}
