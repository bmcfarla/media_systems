using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models
{
    public class GetDMObjectExLocalizedModel : GetDMObjectExLocalizedIpmamModel
    {
        public string dmguid { get; set; }

        GetDMObjectExLocalizedController GetDMObjectExLocalizedController = new GetDMObjectExLocalizedController();

        internal string GetDMObjectExLocalized()
        {
            AxfModel AxfModel = new AxfModel();

            axfdoc = AxfModel.GetDMObjectExLocalizedAxfDoc(dmguid);
            includeAttributes = true;
            includeStrata = false;
            includeAssociations = false;
            includeEssencePackages = false;
            language = "en";
            framerate = "";

            return GetDMObjectExLocalizedController.Get(this);
        }

        
    }
}
