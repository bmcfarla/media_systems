using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models.Ipmam
{
    class GetRepresentativeEssencePackageModel : GetRepresentativeEssencePackageIpmamModel
    {
        public string getRepresentativeEssencePackage() 
        {
            getRepresentativeEssencePackageController getRepresentativeEssencePackage = new getRepresentativeEssencePackageController();
            return getRepresentativeEssencePackage.Get(this).EPGuid;
        }
    }
}
