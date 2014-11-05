using mamSearchAndRetrieval.org.ngs.ipmam.dmObjectAccess;

namespace mamSearchAndRetrieval.Models.Ipmam.Services
{
    public sealed class dmObjectAccessIpmamModel : DMObjectAccess
    {
        static readonly dmObjectAccessIpmamModel _instance = new dmObjectAccessIpmamModel();

        public static dmObjectAccessIpmamModel Instance
        {
            get { return _instance; }
        }
    }
}