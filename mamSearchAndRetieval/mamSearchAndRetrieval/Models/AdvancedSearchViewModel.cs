using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mamSearchAndRetrieval.Models
{
    public class AdvancedSearchViewModel
    {
        public string firstHit { get; set; }
        public string maxHits { get; set; }

        public string keyword { get; set; }
        public string productionID { get; set; }

        public string PRODUCTION_TITLE { get; set; }
        public string PRODUCTION_NUMBER { get; set; }

        public AdvancedSearchViewModel()
        {
            firstHit = "0";
            maxHits = "15";
        }
    }
}
