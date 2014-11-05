using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models.Ipmam
{
    class GetEmObjectsWithFilterModel : GetEmObjectsWithFilterIpmamModel
    {
        internal string GetEMObjectsWithFilter()
        {
            GetEMObjectsWithFilterController GetEMObjectsWithFilter = new GetEMObjectsWithFilterController();
            string[] results = GetEMObjectsWithFilter.Get(this);

            if (results != null && results.Length > 0)
            {
                return GetEMObjectsWithFilter.Get(this)[0];
            }
            else
            {
                return "";
            }
        }
    }
}
