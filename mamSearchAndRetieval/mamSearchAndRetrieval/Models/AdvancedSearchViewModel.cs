using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using mamSearchAndRetrieval.org.ngs.ipmam.dmLegalListEx2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Models
{
    public class AdvancedSearchViewModel
    {
        public string firstHit { get; set; }
        public string maxHits { get; set; }

        [DisplayName("Age")]
        public string AGE { get; set; }
        
        [DisplayName("Air Date")]
        public string AIR_DATE { get; set; }

        [DisplayName("Alternate Production Title")]
        public string ALTERNATE_PRODUCTION_TITLE { get; set; }
        
        [DisplayName("Aspect Ratio")]
        public string ASPECT_RATIO { get; set; }
        
        [DisplayName("Asset Tape Format")]
        public string ASSET_TAPE_FORMAT { get; set; }
        
        [DisplayName("Audio Type")]
        public string AUDIO_TYPE { get; set; }
        
        [DisplayName("Audio Available")]
        public string AUDIO_AVAILABLE { get; set; }
        
        [DisplayName("Category")]
        public string CATEGORY { get; set; }
        
        [DisplayName("Clip Tape Description")]
        public string CLIP_TAPE_DESCRIPTION { get; set; }
        
        [DisplayName("Color")]
        public string COLOR { get; set; }
        
        [DisplayName("Compisistion Effect")]
        public string COMPOSITION_EFFECT { get; set; }
        
        [DisplayName("Concept")]
        public string CONCEPT { get; set; }
        
        [DisplayName("Distribution Strand")]
        public string DISTRIBUTION_STRAND { get; set; }
        
        [DisplayName("Era")]
        public string ERA { get; set; }
        
        [DisplayName("Ethnicity")]
        public string ETHNICITY { get; set; }
        
        [DisplayName("Film Available")]
        public string FILM_AVAILABLE { get; set; }
        
        [DisplayName("Gender")]
        public string GENDER { get; set; }
        
        [DisplayName("Geo Id")]
        public string GEO_ID { get; set; }
        
        [DisplayName("Hd Available")]
        public string HD_AVAILABLE { get; set; }
        
        [DisplayName("In Out Program")]
        public string IN_OUT_PROGRAM { get; set; }
        
        [DisplayName("Keyword")]
        public string KEYWORD { get; set; }
        
        [DisplayName("Language")]
        public string LANGUAGE { get; set; }
        
        [DisplayName("Level")]
        public string LEVEL { get; set; }
        
        [DisplayName("Location")]
        public string LOCATION { get; set; }
        
        [DisplayName("Original Camera Element")]
        public string ORIGINAL_CAMERA_ELEMENT { get; set; }
        
        [DisplayName("Original Capture Method")]
        public string ORIGINAL_CAPTURE_METHOD { get; set; }
        
        [DisplayName("Overall Rights Control Code")]
        public string OVERALL_RIGHTS_CONTROL_CODE { get; set; }
        
        [DisplayName("Overall Rights Notes")]
        public string OVERALL_RIGHTS_NOTES { get; set; }
        
        [DisplayName("Population")]
        public string POPULATION { get; set; }
        
        [DisplayName("Predominant Color")]
        public string PREDOMINANT_COLOR { get; set; }
        
        [DisplayName("Production Number")]
        public string PRODUCTION_NUMBER { get; set; }
        
        [DisplayName("Production Owner")]
        public string PRODUCTION_OWNER { get; set; }
        
        [DisplayName("Production Title")]
        public string PRODUCTION_TITLE { get; set; }
        
        [DisplayName("Roll Number")]
        public string ROLL_NUMBER { get; set; }
        
        [DisplayName("Sales Procedures")]
        public string SALES_PROCEDURES { get; set; }
        
        [DisplayName("Season")]
        public string SEASON { get; set; }
        
        [DisplayName("Standard")]
        public string STANDARD { get; set; }
        
        [DisplayName("Time Of Day")]
        public string TIME_OF_DAY { get; set; }
        
        [DisplayName("Type")]
        public string TYPE { get; set; }
        
        public AdvancedSearchViewModel()
        {
            firstHit = "0";
            maxHits = "15";
        }

        public List<SelectListItem> getLegalListValues(string name, AppUser appUser)
        {
            
            GetDMLegalListLocalizedIpmamModel model = new GetDMLegalListLocalizedIpmamModel
            {
                accesskey = appUser.Token,
                legalListName = name,
                language = "en"
            };

            GetDMLegalListLocalizedController getDMLegalListLocalizedController = new GetDMLegalListLocalizedController();


            LegalListLocalized result = getDMLegalListLocalizedController.Get(model);

            List<SelectListItem> list = new List<SelectListItem>();

            list.Add(new SelectListItem { Text = "", Value = "" });

            foreach (LegalListEntryLocalized entry in result.entries) {
                list.Add(new SelectListItem { Text = entry.label, Value = entry.id.ToString() });
            }

            list = list.OrderBy(x => x.Text).ToList();

            return list;
        }
    }
}










