using mamSearchAndRetrieval.Controllers.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using System;
using System.Collections.Generic;
using System.Xml;

namespace mamSearchAndRetrieval.Models
{
    public class BrowseModel
    {
        public string browseUrl { get; set; }
        public Dictionary<string, string> metaTags { get; set; }

        public string dmGuid { get; set; }
        public string epGuid { get; set; }
        public string token { get; set; }

        public string browseEmGuid { get; set; }

        public BrowseModel(string dmguid, string epguid, string token)
        {
            this.dmGuid = dmguid;
            this.epGuid = epguid;
            this.token = token;
            
            getBowseUrl();
            getMetaData();
        }

        private void getMetaData()
        {
            string result = "";

            try
            {
                GetDMObjectAttributesByDMGUIDModel GetAttributes = new GetDMObjectAttributesByDMGUIDModel
                {
                    accesskey = token,
                    dmguid = dmGuid
                };

                result = GetAttributes.GetDMObjectAttributesByDMGUID();

                // Search
                if (result == "")
                {
                    //RedirectToAction("LogOut", "Auth");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                //RedirectToAction("LogOut", "Auth");
            }

            // Extract Data
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(result);
            XmlNode root = doc.DocumentElement;

            XmlNodeList maObjectMetaAttributes = root.SelectNodes("//MAObject/Meta");

            //List<MetaTagModel> items = new List<MetaTagModel>();
            Dictionary<string, string> items = new Dictionary<string, string>();

            foreach (XmlNode item in maObjectMetaAttributes)
            {
                items.Add(item.Attributes["name"].Value, item.InnerText);
            }

            metaTags = items;

 
            //return Newtonsoft.Json.JsonConvert.SerializeObject(this);

            //return js.Serialize(browseModel.ToString());
        
        }

        private void getBowseUrl()
        {
            GetEmObjectsWithFilterModel GetEmObjects = new GetEmObjectsWithFilterModel
            {
                accessKey = token,
                epguid = epGuid,
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

                browseUrl = EssenceManagerController.GetAccessPath(getAccessPathModel);
            }
        }

    }
}
