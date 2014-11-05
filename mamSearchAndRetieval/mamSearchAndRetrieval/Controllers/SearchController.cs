using mamSearchAndRetrieval.Models;
using mamSearchAndRetrieval.Models.Ipmam;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    public class SearchController : AppController
    {
        public ActionResult Index(SimpleSearchModel model)
        {
            ResultsViewModel resultsViewModel = getResultsViewModel(model);

            TempData["resultsViewModel"] = resultsViewModel;

            return RedirectToAction("Index","Results");
        }

        public ActionResult Simple()
        {
            
            return View();
        }

        private ResultsViewModel getResultsViewModel(SimpleSearchModel model)
        {
            ResultsViewModel ResultsModel = new ResultsViewModel(model, this.CurrentUser.Token);

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