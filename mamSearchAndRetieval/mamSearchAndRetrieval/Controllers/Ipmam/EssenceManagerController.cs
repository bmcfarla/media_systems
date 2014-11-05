using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using System;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers.Ipmam
{
    public class EssenceManagerController : Controller
    {
        public static String GetAccessPath(GetAccessPathModel model)
        {
            return model.GetAccessPath();
        }
    }
}