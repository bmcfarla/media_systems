using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models.Ipmam
{
    public class GetUserPropertyModel : GetUserPropertyIpmamModel
    {
        public string GetUserProperty() 
        {
            GetUserPropertyController getAccessPath = new GetUserPropertyController();

            return getAccessPath.Get(this);
        }
    }
}
