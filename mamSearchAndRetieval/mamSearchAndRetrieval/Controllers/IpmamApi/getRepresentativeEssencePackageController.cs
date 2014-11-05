using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using mamSearchAndRetrieval.org.ngs.ipmam.dmEssencePackages;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class getRepresentativeEssencePackageController : ApiController
    {
        dmEssencePackagesModel dmEssencePackages = dmEssencePackagesModel.Instance;

        public EssencePackage Get(GetRepresentativeEssencePackageModel model)
        {
            return dmEssencePackages.GetRepresentativeEssencePackage(model.accessKey, model.dmGuid);
        }
    }
}
