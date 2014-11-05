using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class GetDMObjectAttributesByDMGUIDController : ApiController
    {
        dmObjectAccessIpmamModel dmObjectAccess = dmObjectAccessIpmamModel.Instance;

        public string Get(GetDMObjectAttributesByDMGUIDIpmamModel model)
        {

            return dmObjectAccess.GetDMObjectAttributesByDMGUID(model.dmguid, model.accesskey);
        }
    }
}
