using mamSearchAndRetrieval.Models.Ipmam.Resources;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class GetUserPropertyController : ApiController
    {
        umModel um = umModel.Instance;

        public string Get(GetUserPropertyIpmamModel model)
        {
            return um.GetUserProperty(model.accesstoken, model.property);
        }
    }
}
