using mamSearchAndRetrieval.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace mamSearchAndRetrieval.Controllers
{
    public class ResultsController : AppController
    {
        private ResultsViewModel resultsViewModel;
        
        // GET: Results
        public ActionResult Index(SimpleSearchModel model)
        {

            //resultsViewModel = TempData["resultsViewModel"] as ResultsViewModel;
            ResultsViewModel resultsViewModel = getResultsViewModel(model);

            return View(resultsViewModel);
        }

        public ActionResult PartialGrid(SimpleSearchModel model)
        {
            ResultsViewModel resultsViewModel = getResultsViewModel(model);

            return PartialView("_gridPartial", resultsViewModel);
        }

        private ResultsViewModel getResultsViewModel(SimpleSearchModel model)
        {
            ResultsViewModel ResultsModel = new ResultsViewModel(model, this.CurrentUser.Token);

            return ResultsModel;
        }

    }
}