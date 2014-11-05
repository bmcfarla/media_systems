using mamSearchAndRetrieval.org.ngs.ipmam.essenceManager;

namespace mamSearchAndRetrieval.Models.Ipmam.Services
{
    public sealed class essenceManagerIpmamModel : EssenceManager
    {
        static readonly essenceManagerIpmamModel _instance = new essenceManagerIpmamModel();

        public static essenceManagerIpmamModel Instance
        {
            get { return _instance; }
        }
    }
}