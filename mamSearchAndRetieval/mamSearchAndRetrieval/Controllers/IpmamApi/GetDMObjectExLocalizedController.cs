using mamSearchAndRetrieval.Models.Ipmam.Resources;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    class GetDMObjectExLocalizedController : ApiController
    {
        dmObjectAccessIpmamModel dmObjectAccess = dmObjectAccessIpmamModel.Instance;

        public string Get(GetDMObjectExLocalizedIpmamModel model)
        {

            return dmObjectAccess.GetDMObjectExLocalized(
                model.axfdoc, 
                model.accesskey, 
                model.includeAttributes, 
                model.includeStrata, 
                model.includeAssociations, 
                model.includeEssencePackages, 
                model.language, 
                model.framerate
                );
        }
    }
}
