using mamSearchAndRetrieval.org.ngs.ipmam.dmSearch;

namespace mamSearchAndRetrieval.Models.Ipmam.Services
{
    public sealed class dmSearchModel : DMSearch
    {
        static readonly dmSearchModel _instance = new dmSearchModel();

        public static dmSearchModel Instance
        {
            get { return _instance; }
        }
    }
}