using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;

namespace mamSearchAndRetrieval.Models
{
    public class MetadataModel
    {
        private string dmguid;
        private string token;

        public MetadataReturnModel metadata { get; set; }

        public MetadataModel(string dmguid, string token)
        {
            this.dmguid = dmguid;
            this.token = token;

            this.metadata = getMetadata();
        }

        private MetadataReturnModel getMetadata()
        {
            MetadataReturnModel metadataReturnModel = new MetadataReturnModel();
            
            string result = "";

            try
            {
                GetDMObjectExLocalizedModel GetAttributes = new GetDMObjectExLocalizedModel
                {
                    accesskey = token,
                    dmguid = dmguid
                };

                result = GetAttributes.GetDMObjectExLocalized();
            }
            catch
            {
                
            }

            // Extract Data
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(result);
            XmlNode root = doc.DocumentElement;

            XmlNodeList maObjectMetaAttributes = root.SelectNodes("//MAObject/Meta");
            XmlNodeList maObjectMvAttributes = root.SelectNodes("//MVAttribute");

            //List<MetaTagModel> items = new List<MetaTagModel>();
            Dictionary<string, string> items = new Dictionary<string, string>();

            foreach (XmlNode item in maObjectMetaAttributes)
            {
                items.Add(item.Attributes["name"].Value, item.InnerText);
            }

            Dictionary<string,List<Dictionary<string, string>>> MvItems = new Dictionary<string, List<Dictionary<string, string>>>();

            foreach (XmlNode item in maObjectMvAttributes)
            {
                string mvaName = item.Attributes["type"].Value;
                string mvaIndex = item.Attributes["index"].Value;
                Dictionary<string, string> nameValue = new Dictionary<string, string>();
                //Dictionary<string, Dictionary<string, string>> indexDict = new Dictionary<string, Dictionary<string, string>>();
                List<Dictionary<string, string>> indexDict = new List<Dictionary<string, string>>();
                //List<Dictionary<string,string>>

                foreach (XmlNode child in item.ChildNodes)
                {
                    string name = child.Attributes["name"].Value;
                    nameValue.Add(name, child.InnerText);

                    if (name == "USAGE" && child.InnerText == "EDIT")
                    {
                        if (!items.ContainsKey("EditProxyId"))
                        {
                            items.Add("EditProxyId", mvaIndex);
                        }
                    }
                }

                if (MvItems.ContainsKey(mvaName))
                {
                    if (int.Parse(mvaIndex) < MvItems[mvaName].Count) 
                    {
                        MvItems[mvaName][0] = nameValue;
                    }
                    else
                    {
                        MvItems[mvaName].Add(nameValue);
                    }
                }
                else
                {
                    indexDict.Add(nameValue);
                    MvItems.Add(mvaName, indexDict);
                }
            }

            metadataReturnModel.items = items;
            metadataReturnModel.MvAttributeItems = MvItems;

            //var a = from i in MvItems.Values where item. == "apple" select item;
            //var a = MvItems.Where(p => p.Value == "FLAVOURINFORMATION");
            //Console.WriteLine(a);
            return metadataReturnModel;

        }
    }
}
