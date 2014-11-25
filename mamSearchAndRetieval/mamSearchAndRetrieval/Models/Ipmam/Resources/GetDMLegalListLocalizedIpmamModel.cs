using mamSearchAndRetrieval.org.ngs.ipmam.dmLegalListEx2;

namespace mamSearchAndRetrieval.Models.Ipmam.Resources
{
    public class GetDMLegalListLocalizedIpmamModel
    {
        public string accesskey { get; set; }
        public string legalListName { get; set; }
        public string language { get; set; }
    }

    public class LegalListLocalizedReponse : LegalListLocalized { };

}
