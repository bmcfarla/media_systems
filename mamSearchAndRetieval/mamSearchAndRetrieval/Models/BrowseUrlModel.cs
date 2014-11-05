using mamSearchAndRetrieval.Controllers.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam;

namespace mamSearchAndRetrieval.Models
{
    class BrowseUrlModel
    {
        private   string epguid;
        private   string token;

        private string browseEmGuid;
        public  string browseUrl;

        public BrowseUrlModel(string epguid, string token)
        {
            this.epguid = epguid;
            this.token = token;

            this.browseUrl = getBrowseUrl();
        }

        private string getBrowseUrl () 
        {
            GetEmObjectsWithFilterModel GetEmObjects = new GetEmObjectsWithFilterModel
            {
                accessKey = token,
                epguid = epguid,
                streamtype = "",
                streamclass = "VIDEO",
                usage = "BROWSE"
            };

            browseEmGuid = GetEmObjects.GetEMObjectsWithFilter();

            if (browseEmGuid != null)
            {
                // Get access path to thumbnail
                GetAccessPathModel getAccessPathModel = new GetAccessPathModel
                {
                    accessKey = token,
                    emguid = browseEmGuid,
                    protocol = "HTTP",
                    mode = "READ"
                };

                return EssenceManagerController.GetAccessPath(getAccessPathModel);
            }

            return "";
        }
    }
}

