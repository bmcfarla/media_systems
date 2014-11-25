using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using mamSearchAndRetrieval.org.ngs.ipmam.dmLegalListEx2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    public class HomeController : AppController
    {
        public ActionResult Index()
        {
            GetDMLegalListLocalizedController test = new GetDMLegalListLocalizedController();
            GetDMLegalListLocalizedIpmamModel model = new GetDMLegalListLocalizedIpmamModel
            {
                accesskey = "b273316f-3f70-434e-86ef-a5c61e73db02",
                legalListName = "keyword",
                language = "en"
            };

            LegalListLocalized x = test.Get(model);

            Console.WriteLine(x);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}