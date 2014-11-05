using mamSearchAndRetrieval.org.ngs.ipmam.um;

namespace mamSearchAndRetrieval.Models.Ipmam.Services
{
    public sealed class umModel : UM
    {
        static readonly umModel _instance = new umModel();
        
        public static umModel Instance
        {
            get { return _instance; }
        }
    }
}