using mamSearchAndRetrieval.Controllers.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mamSearchAndRetrieval.Models
{
    class ThumbnailModel
    {
        public string token { get; set; }
        public string thumbnailUrl { get; set; }
        public string thumbnailEmguid { get; set; }
        public string epguid { get; set; }

        public ThumbnailModel(string token)
        {
            this.token = token;
        }


        public void getThumbnailUrlWithDmguid(string dmguid)
        {
            getEguidForDmguid(dmguid);
            getThumbnailUrlWithEpguid(epguid);
            getThumbnailUrlWithEmguid(thumbnailEmguid);
        }

        public void getThumbnailUrlWithEpguid(string epguid)
        {
            getThumbnailEmguid(epguid);
            getThumbnailUrlWithEmguid(thumbnailEmguid);
        }

        public void getThumbnailUrlWithEmguid(string thumbnailEmguid)
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
                thumbnailUrl = "/Content/Images/filler-100x100.png";
            }
        }

        // Get Reppresentative Essence Package
        internal void getEguidForDmguid(string dmguid)
        {
            GetRepresentativeEssencePackageModel GetRepresentativeEssencePackageModel = new GetRepresentativeEssencePackageModel
            {
                accessKey = token,
                dmGuid = dmguid
            };

            epguid = GetRepresentativeEssencePackageModel.getRepresentativeEssencePackage();
        }
        
           // Get the EM guid for the thumbnail
        internal void getThumbnailEmguid(string epguid)
        {
            GetEmObjectsWithFilterModel GetEmObjects = new GetEmObjectsWithFilterModel
            {
                accessKey = token,
                epguid = epguid,
                streamtype = "JPEG",
                streamclass = "IMAGE",
                usage = "THUMB"
            };

            thumbnailEmguid = GetEmObjects.GetEMObjectsWithFilter();
        }
    }
}
