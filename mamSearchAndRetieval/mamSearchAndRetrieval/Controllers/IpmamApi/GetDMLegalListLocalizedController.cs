using mamSearchAndRetrieval.Models.Ipmam.Resources;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using mamSearchAndRetrieval.org.ngs.ipmam.dmLegalListEx2;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class GetDMLegalListLocalizedController : ApiController
    {
        dmLegalListEx2Model dmLegalList = dmLegalListEx2Model.Instance;

        public LegalListLocalized Get(GetDMLegalListLocalizedIpmamModel model)
        {
            return  dmLegalList.GetDMLegalListLocalized(model.accesskey, model.legalListName, model.language);
        }
    }
}
