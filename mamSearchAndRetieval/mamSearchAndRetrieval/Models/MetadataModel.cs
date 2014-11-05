using System;
using System.Collections.Generic;
using System.Xml;

namespace mamSearchAndRetrieval.Models
{
    public class MetadataModel
    {
        private string dmguid;
        private string token;

        public Dictionary<string, string> metadata { get; set; }

        public MetadataModel(string dmguid, string token)
        {
            this.dmguid = dmguid;
            this.token = token;

            this.metadata = getMetadata();
        }

        private Dictionary<string,string> getMetadata()
        {
            string result = "";

            try
            {
                GetDMObjectAttributesByDMGUIDModel GetAttributes = new GetDMObjectAttributesByDMGUIDModel
                {
                    accesskey = token,
                    dmguid = dmguid
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

            return items;

        }
    }
}
