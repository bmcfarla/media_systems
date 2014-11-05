using mamSearchAndRetrieval.Models.Ipmam.Resources;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class SearchEx2Controller : ApiController
    {
        dmSearchModel dmSeach = dmSearchModel.Instance;

        public string Get(SearchEx2IpmamModel model)
        {
            return dmSeach.SearchExt2(model.accessKey, model.queryDoc, model.hitlistDoc, model.language);
        }
    }
}
