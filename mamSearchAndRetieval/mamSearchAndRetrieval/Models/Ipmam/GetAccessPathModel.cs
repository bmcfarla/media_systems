using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models.Ipmam
{
    public class GetAccessPathModel : GetAccessPathIpmamModel
    {
        public string GetAccessPath() 
        {
            GetAccessPathIpmamApiController getAccessPath = new GetAccessPathIpmamApiController();

            return getAccessPath.Get(this);
        }
    }
}
