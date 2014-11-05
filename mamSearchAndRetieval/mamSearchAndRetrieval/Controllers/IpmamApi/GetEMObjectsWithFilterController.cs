using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class GetEMObjectsWithFilterController : ApiController
    {
        essenceManagerIpmamModel essenceManager = essenceManagerIpmamModel.Instance;

        public string[] Get(GetEmObjectsWithFilterModel model)
        {
            return essenceManager.GetEMObjectsWithFilter(model.accessKey, model.epguid, model.streamtype, model. streamclass, model.usage);
        }
    }
}
