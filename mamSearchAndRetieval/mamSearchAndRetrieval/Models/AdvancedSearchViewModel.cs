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

        [DisplayName("Air Date")]
        public string AIR_DATE { get; set; }

        [DisplayName("Aspect Ratio")]
        public string ASPECT_RATIO { get; set; }
        
        [DisplayName("Category")]
        public string CATEGORY { get; set; }

        [DisplayName("Concept")]
        public string CONCEPT { get; set; }

        [DisplayName("Clip/Tape Description")]
        public string CLIP_TAPE_DESCRIPTION { get; set; }

        [DisplayName("Film Available")]
        public string FILM_AVAILABLE { get; set; }

        [DisplayName("HD Available")]
        public string HD_AVAILABLE { get; set; }

        [DisplayName("IN / OUT / PROG")]
        public string IN_OUT_PROGRAM { get; set; }

        [DisplayName("Keyword")]
        public string KEYWORD { get; set; }

        [DisplayName("Level")]
        public string LEVEL { get; set; }

        [DisplayName("Locaiton")]
        public string LOCATION { get; set; }

        [DisplayName("Original Camera Element")]
        public string ORIGINAL_CAMERA_ELEMENT { get; set; }

        [DisplayName("Original Caputure Method")]
        public string ORIGINAL_CAPTURE_METHOD { get; set; }

        [DisplayName("Produjction Title")]
        public string PRODUCTION_TITLE { get; set; }

        [DisplayName("Production Number")]
        public string PRODUCTION_NUMBER { get; set; }

        [DisplayName("Production Owner")]
        public string PRODUCTION_OWNER { get; set; }

        [DisplayName("Roll Number")]
        public string ROLL_NUMBER { get; set; }

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

            return list;
        }
    }
}










