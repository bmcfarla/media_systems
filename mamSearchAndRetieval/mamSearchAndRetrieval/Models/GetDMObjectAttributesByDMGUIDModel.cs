using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models
{
    public class GetDMObjectAttributesByDMGUIDModel : GetDMObjectAttributesByDMGUIDIpmamModel
    {
        GetDMObjectAttributesByDMGUIDController GetDMObjectAttributesByDMGUIDController = new GetDMObjectAttributesByDMGUIDController();
    
        internal string GetDMObjectAttributesByDMGUID()
        {
            return GetDMObjectAttributesByDMGUIDController.Get(this);
        }
    }
}
