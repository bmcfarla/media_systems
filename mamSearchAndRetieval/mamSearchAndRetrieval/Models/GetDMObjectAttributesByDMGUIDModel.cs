using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
