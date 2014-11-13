using mamSearchAndRetrieval.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace mamSearchAndRetrieval.Controllers
{
    public class ResultsController : AppController
    {
        
        // GET: Results
        public ActionResult Index(SimpleSearchModel model)
        {
            try
            {
                //resultsViewModel = TempData["resultsViewModel"] as ResultsViewModel;
                ResultsViewModel resultsViewModel = getResultsViewModel(model);
                return View(resultsViewModel);

            }
            catch
            {
                return RedirectToAction("Logout", "Auth");
            }

            
        }

        public ActionResult PartialGrid(SimpleSearchModel model)
        {
            ResultsViewModel resultsViewModel = getResultsViewModel(model);

            return PartialView("_gridPartial", resultsViewModel);
        }

        private ResultsViewModel getResultsViewModel(SimpleSearchModel model)
        {
            ResultsViewModel ResultsModel = new ResultsViewModel(model, this.CurrentUser);

            return ResultsModel;
        }

        public ActionResult Cart()
        {

            return Json("Not Implemented Yet",JsonRequestBehavior.AllowGet);
        }

        public ActionResult EmptyCart()
        {

            return Json("Not Implemented Yet", JsonRequestBehavior.AllowGet);
        }
    }
}