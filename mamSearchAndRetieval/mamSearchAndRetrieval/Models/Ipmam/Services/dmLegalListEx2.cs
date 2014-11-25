using mamSearchAndRetrieval.org.ngs.ipmam.dmLegalListEx2;

namespace mamSearchAndRetrieval.Models.Ipmam.Services
{
    public sealed class dmLegalListEx2Model : DMLegalListEx2
    {
        static readonly dmLegalListEx2Model _instance = new dmLegalListEx2Model();

        public static dmLegalListEx2Model Instance
        {
            get { return _instance; }
        }
    }
}