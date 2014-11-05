using mamSearchAndRetrieval.Models;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    public class RetrievalController : AppController
    {
        // GET: Retrieval
        public ActionResult Details(string dmguid, string token)
        {
            RetrievalModel retrievalModel = new RetrievalModel(dmguid,token);
            
            return View(retrievalModel);
        }
    }
}