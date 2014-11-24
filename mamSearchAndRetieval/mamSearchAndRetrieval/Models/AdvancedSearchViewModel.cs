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

        public string AIR_DATE { get; set; }
        public string ASPECT_RATIO { get; set; }
        public string CATEGORY { get; set; }
        public string CONCEPT { get; set; }
        public string DESCRIPTION { get; set; }
        public string FILM_AVAILABLE { get; set; }
        public string HD_AVAILABLE { get; set; }
        public string IN_OUT_PROGRAM { get; set; }
        public string KEYWORD { get; set; }
        public string LEVEL { get; set; }
        public string ORIGINAL_CAMERA_ELEMENT { get; set; }
        public string ORIGINAL_CAPTURE_METHOD { get; set; }
        public string PRODUCTION_TITLE { get; set; }
        public string PRODUCTION_NUMBER { get; set; }
        public string PRODUCTION_OWNER { get; set; }
        public string ROLL_NUMBER { get; set; }

        public AdvancedSearchViewModel()
        {
            firstHit = "0";
            maxHits = "15";
        }
    }
}










