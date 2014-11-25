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
                                      "KEYWORD",
                                      "CONCEPT",
                                      "LOCATION",
                                      "LEVEL",
                                      "CATEGORY"
                                  };


            foreach (string list in legalLists)
            {
                ViewData[list] = advancedSearchViewModel.getLegalListValues(list, this.CurrentUser);
            }

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