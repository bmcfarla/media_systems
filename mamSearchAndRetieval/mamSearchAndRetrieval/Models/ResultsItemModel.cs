using mamSearchAndRetrieval.Controllers.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models
{
    public class ResultsItemModel
    {
        public string token { get; set; }
        public string dmGuid { get; set; }
        public string epGuid { get; set; }
        public string thumbnailEmguid { get; set; }
        public string thumbnailUrl { get; set; }
        public string browseUrl { get; set; }
        public string mainTitle { get; set; }
        public bool cartSelected { get; set; }

        internal void getThumbnailUrl()
        {
            if (thumbnailEmguid != "")
            {
                // Get access path to thumbnail
                GetAccessPathModel getAccessPathModel = new GetAccessPathModel
                {
                    accessKey = token,
                    emguid = thumbnailEmguid,
                    protocol = "HTTP",
                    mode = "READ"
                };

                thumbnailUrl = EssenceManagerController.GetAccessPath(getAccessPathModel);
            }
            else
            {
                thumbnailUrl = "FILLER";
            }
        }

        // Get the EM guid for the thumbnail
        internal void getThumbnailEmguid()
        {
            GetEmObjectsWithFilterModel GetEmObjects = new GetEmObjectsWithFilterModel
            {
                accessKey = token,
                epguid = epGuid,
                streamtype = "JPEG",
                streamclass = "IMAGE",
                usage = "THUMB"
            };

            thumbnailEmguid = GetEmObjects.GetEMObjectsWithFilter();
        }

        // Get Reppresentative Essence Package
        internal void getEpGuid()
        {
            GetRepresentativeEssencePackageModel RepEp = new GetRepresentativeEssencePackageModel
            {
                accessKey = token,
                dmGuid = dmGuid
            };

            epGuid = RepEp.getRepresentativeEssencePackage();
        }


    }
}