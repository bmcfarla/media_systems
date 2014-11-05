using mamSearchAndRetrieval.org.ngs.ipmam.dmEssencePackages;

namespace mamSearchAndRetrieval.Models.Ipmam.Services
{
    public sealed class dmEssencePackagesModel : DMEssencePackages
    {
        static readonly dmEssencePackagesModel _instance = new dmEssencePackagesModel();

        public static dmEssencePackagesModel Instance
        {
            get { return _instance; }
        }
    }
}