
using System.Collections.Generic;
namespace mamSearchAndRetrieval.Models
{
    public class RetrievalModel
    {
        public string token { get; set; }
        public string dmguid { get; set; }
        public string thumbnailUrl { get; set; }
        public Dictionary<string, string> metadata { get; set; }

        public RetrievalModel(string dmguid, string token)
        {
            this.token = token;
            this.dmguid = dmguid;

            retrieveThumbnail();
            retrieveMetadata();
        }

        private void retrieveThumbnail()
        {
            ThumbnailModel thumbnailModel = new ThumbnailModel(token);

            thumbnailModel.getThumbnailUrlWithDmguid(dmguid);

            thumbnailUrl = thumbnailModel.thumbnailUrl;
        }

        private void retrieveMetadata()
        {
            MetadataModel metadataModel = new MetadataModel(dmguid, token);

            //metadata = Newtonsoft.Json.JsonConvert.SerializeObject(metadataModel.metadata);
            metadata = metadataModel.metadata;
        }
    }
}
