using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class GetAccessPathIpmamApiController : ApiController
    {
        essenceManagerIpmamModel essenceManager = essenceManagerIpmamModel.Instance;

        public string Get(GetAccessPathIpmamModel model)
        {
            return essenceManager.GetAccessPath(model.accessKey, model.emguid, model.protocol, model.mode);
        }
    }
}
