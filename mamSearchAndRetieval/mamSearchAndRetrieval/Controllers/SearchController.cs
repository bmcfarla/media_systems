using mamSearchAndRetrieval.Models;
using mamSearchAndRetrieval.Models.Ipmam;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    public class SearchController : AppController
    {
        public ActionResult Index(SimpleSearchModel model)
        {
            try
            {
                ResultsViewModel resultsViewModel = getResultsViewModel(model);

                TempData["resultsViewModel"] = resultsViewModel;

                return RedirectToAction("Index", "Results");
            }
            catch
            {
                return RedirectToAction("Logout", "Auth");
            }
        }

        public ActionResult Simple()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult Advanced()
        {
            AdvancedSearchViewModel advancedSearchViewModel = new AdvancedSearchViewModel();

            //@Html.TextBox("PRODUCTION_NUMBER", null, htmlAttributes: new { @class = "form-control", @placeholder = "Production Number" })
            //</div>
            //<div class="col-lg-3">
            //    @Html.DropDownList("KEYWORD", null, htmlAttributes: new { @class = "form-control", @placeholder = "Keyword" })

            string[] legalLists = {
                                      "CATEGORY",
                                      "CONCEPT",
                                      "KEYWORD",
                                      "LOCATION",
                                      "LEVEL",
                                      "PRODUCTION_OWNER",
                                      "ORIGINAL_CAMERA_ELEMENT",
                                      "ORIGINAL_CAPTURE_METHOD",
                                      "CAMERA_SHOT",
                                      "CAMERA_SPEED",
                                      "CAMERA_ACTION",
                                      "CAMERA_LOCATION",
                                      "ASPECT_RATIO",
                                      "TIME_OF_DAY",
                                      "POPULATION",
                                      "SEASON",
                                      "GENDER",
                                      "ETHNICITY",
                                      "AGE",
                                      "AUDIO_TYPE",
                                      "ERA",
                                      "PREDOMINANT_COLOR",
                                      "COLOR",
                                      "TYPE",
                                      "STANDARD",
                                      "LANGUAGE",
                                      "DISTRIBUTION_STRAND",
                                      "IN_OUT_PROG",
                                      "ASSET_FORMAT",
                                      "AUDIO_TYPE",
                                      "COMPOSITION_EFFECT"
                                  };


            foreach (string list in legalLists)
            {
                ViewData[list] = advancedSearchViewModel.getLegalListValues(list, this.CurrentUser);
            }

            
            ViewData["HD_AVAILABLE"] = new List<SelectListItem> { 
                new SelectListItem { Text = "", Value = "" }, 
                new SelectListItem { Text = "Yes", Value = "1" }, 
                new SelectListItem { Text = "No", Value = "0" }
            };

            ViewData["FILM_AVAILABLE"] = new List<SelectListItem> { 
                new SelectListItem { Text = "", Value = "" }, 
                new SelectListItem { Text = "Yes", Value = "1" }, 
                new SelectListItem { Text = "No", Value = "0" }
            };

            ViewData["AUDIO_AVAILABLE"] = new List<SelectListItem> { 
                new SelectListItem { Text = "", Value = "" }, 
                new SelectListItem { Text = "Yes", Value = "1" }, 
                new SelectListItem { Text = "No", Value = "0" }
            };

            return View();
        }

        [HttpPost]
        public ActionResult Advanced(AdvancedSearchViewModel model)
        {
            //try
            //{
                ResultsViewModel resultsViewModel = getResultsViewModel(model);

                TempData["resultsViewModel"] = resultsViewModel;

                return RedirectToAction("Advanced", "Results");
            //}
            //catch
            //{
            //    return RedirectToAction("Logout", "Auth");
            //}
        }

        private ResultsViewModel getResultsViewModel(SimpleSearchModel model)
        {
            ResultsViewModel ResultsModel = new ResultsViewModel(model, this.CurrentUser);

            return ResultsModel;
        }

        private ResultsViewModel getResultsViewModel(AdvancedSearchViewModel model)
        {
            ResultsViewModel ResultsModel = new ResultsViewModel(model, this.CurrentUser);

            return ResultsModel;
        }

        public string browseUrl(string epguid, string token)
        {
            BrowseUrlModel browseUrlModel = new BrowseUrlModel(epguid, token);

            return browseUrlModel.browseUrl;
        }

        public string metadata(string dmguid, string token)
        {
            MetadataModel metadataModel = new MetadataModel(dmguid, token);

            return Newtonsoft.Json.JsonConvert.SerializeObject(metadataModel.metadata);
        }
    }
}