using System;
using System.Reflection;
using System.Xml.Linq;

namespace mamSearchAndRetrieval.Models.Ipmam.Resources
{
    public class AxfModel
    {
        internal string GetDMObjectExLocalizedAxfDoc(string dmguid)
        {
            XElement queryDoc = new XElement(
                   "AXFRoot",
                       new XElement("MAObject",
                           new XAttribute("type", "default"),
                           new XAttribute("mdclass", "DMQuery"),
                           new XElement("GUID", dmguid)
                           )
                       );
            return queryDoc.ToString();
        }

        internal string simpleSeachQueryDoc(SimpleSearchModel model)
        {
            XElement queryDoc = new XElement(
                   "AXFRoot",
                       new XElement("MAObject",
                           new XAttribute("type", "default"),
                           new XAttribute("mdclass", "DMQuery"),
                           new XElement("GUID", "theID"),
                           new XElement("Meta",
                               new XAttribute("name", "OBJECTCLASSES"),
                               new XAttribute("format", "string"),
                               "VIDEO"),
                           new XElement("Meta",
                               new XAttribute("name", "SIMPLESEARCH"),
                               new XAttribute("format", "string"),
                               model.searchString),
                           new XElement("Meta",
                               new XAttribute("name", "FIRSTHIT"),
                               new XAttribute("format", "string"),
                               model.firstHit),
                           new XElement("Meta",
                               new XAttribute("name", "MAXHITS"),
                               new XAttribute("format", "string"),
                               model.maxHits),
                           new XElement("Meta",
                               new XAttribute("name", "HITLISTID"),
                               new XAttribute("format", "string"),
                               "01 - Default")
                           )
                       );
            return queryDoc.ToString();
        }

        internal string hitlistDoc()
        {
            XElement hitlistDoc = new XElement(
                        "AXFRoot",
                        new XElement("MAObject",
                            new XAttribute("type", "default"),
                            new XAttribute("mdclass", "ModelHitlistAttribute"),
                            new XElement("GUID",
                                new XAttribute("dmname", ""),
                                "0"),
                            new XElement("Meta",
                                new XAttribute("name", "NAME"),
                                new XAttribute("format", "string"),
                                new XAttribute("frate", ""),
                                "MAINTITLE"),
                            new XElement("Ref",
                                new XAttribute("mdclass", "ModelHitlist"),
                                new XAttribute("name", "HITLIST"),
                                "theHitlist")
                            ),
                        new XElement("MAObject",
                            new XAttribute("type", "default"),
                            new XAttribute("mdclass", "ModelHitlist"),
                            new XElement("GUID", "theHitlist"),
                            new XElement("Meta",
                                new XAttribute("name", "MODIFYABLE"),
                                new XAttribute("format", "string"),
                                "1"),
                            new XElement("Meta",
                                new XAttribute("name", "USAGE"),
                                new XAttribute("format", "string"),
                                "RETRIEVAL")
                            )
                        );

            return hitlistDoc.ToString();
        }

        internal string advancedSeachQueryDoc(AdvancedSearchViewModel model)
        {
            XElement queryDoc = new XElement(
                   "AXFRoot",
                       new XElement("MAObject",
                           new XAttribute("type", "default"),
                           new XAttribute("mdclass", "DMQuery"),
                           new XElement("GUID", "theID"),
                           new XElement("Meta",
                               new XAttribute("name", "OBJECTCLASSES"),
                               new XAttribute("format", "string"),
                               "VIDEO"),
                           new XElement("Meta",
                               new XAttribute("name", "SIMPLESEARCH"),
                               new XAttribute("format", "string"),
                               ""),
                           new XElement("Meta",
                               new XAttribute("name", "FIRSTHIT"),
                               new XAttribute("format", "string"),
                               model.firstHit),
                           new XElement("Meta",
                               new XAttribute("name", "MAXHITS"),
                               new XAttribute("format", "string"),
                               model.maxHits),
                           new XElement("Meta",
                               new XAttribute("name", "HITLISTID"),
                               new XAttribute("format", "string"),
                               "01 - Default")
                           )
                           );
            Type type = model.GetType();
            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props) {
                if (prop.GetValue(model) != null && !(prop.Name == "firstHit" || prop.Name == "maxHits"))
                {
                    queryDoc.Add(new XElement("MAObject",
                               new XAttribute("type", "default"),
                               new XAttribute("mdclass", "AttributeSearch"),
                               new XElement("GUID", ""),
                               new XElement("Ref",
                                    new XAttribute("mdclass", "DMQuery"),
                                    new XAttribute("name", "QUERY"),
                                    "theID"),
                                new XElement("Meta",
                                    new XAttribute("name", "ATTRIBUTE"),
                                    new XAttribute("format", "string"),
                                    prop.Name),
                                new XElement("Meta",
                                   new XAttribute("name", "SEARCHSTRING"),
                                   new XAttribute("format", "string"),
                                   string.Format("{0}", prop.GetValue(model).ToString())),
                                new XElement("Meta",
                                   new XAttribute("name", "GROUP"),
                                   new XAttribute("format", "string"),
                                   "1")
                                )
                    );
                }
            }
            //queryDoc.Add(new XElement("MAObject",
            //               new XAttribute("type", "default"),
            //               new XAttribute("mdclass", "AttributeSearch"),
            //               new XElement("GUID", ""),
            //               new XElement("Ref",
            //                    new XAttribute("mdclass", "DMQuery"),
            //                    new XAttribute("name", "QUERY"),
            //                    "theID"),
            //                new XElement("Meta",
            //                    new XAttribute("name", "ATTRIBUTE"),
            //                    new XAttribute("format", "string"),
            //                    "PRODUCTION_NUMBER"),
            //                new XElement("Meta",
            //                   new XAttribute("name", "SEARCHSTRING"),
            //                   new XAttribute("format", "string"),
            //                   "91S06"),
            //                new XElement("Meta",
            //                   new XAttribute("name", "GROUP"),
            //                   new XAttribute("format", "string"),
            //                   "1")
            //                )
        //);
            return queryDoc.ToString();
        }


        internal string advancedSeachQueryDocSAVE(AdvancedSearchViewModel model)
        {
            XElement queryDoc = new XElement(
                   "AXFRoot",
                       new XElement("MAObject",
                           new XAttribute("type", "default"),
                           new XAttribute("mdclass", "DMQuery"),
                           new XElement("GUID", "theID"),
                           new XElement("Meta",
                               new XAttribute("name", "OBJECTCLASSES"),
                               new XAttribute("format", "string"),
                               "VIDEO"),
                           new XElement("Meta",
                               new XAttribute("name", "SIMPLESEARCH"),
                               new XAttribute("format", "string"),
                               ""),
                           new XElement("Meta",
                               new XAttribute("name", "FIRSTHIT"),
                               new XAttribute("format", "string"),
                               model.firstHit),
                           new XElement("Meta",
                               new XAttribute("name", "MAXHITS"),
                               new XAttribute("format", "string"),
                               model.maxHits),
                           new XElement("Meta",
                               new XAttribute("name", "HITLISTID"),
                               new XAttribute("format", "string"),
                               "01 - Default")
                           ),
                        new XElement("MAObject",
                           new XAttribute("type", "default"),
                           new XAttribute("mdclass", "AttributeSearch"),
                           new XElement("GUID", ""),
                           new XElement("Ref",
                                new XAttribute("mdclass", "DMQuery"),
                                new XAttribute("name", "QUERY"),
                                "theID"),
                            new XElement("Meta",
                                new XAttribute("name", "ATTRIBUTE"),
                                new XAttribute("format", "string"),
                                "PRODUCTION_TITLE"),
                            new XElement("Meta",
                               new XAttribute("name", "SEARCHSTRING"),
                               new XAttribute("format", "string"),
                               "cats"),
                            new XElement("Meta",
                               new XAttribute("name", "GROUP"),
                               new XAttribute("format", "string"),
                               "1")
                            ),
                         new XElement("MAObject",
                           new XAttribute("type", "default"),
                           new XAttribute("mdclass", "AttributeSearch"),
                           new XElement("GUID", ""),
                           new XElement("Ref",
                                new XAttribute("mdclass", "DMQuery"),
                                new XAttribute("name", "QUERY"),
                                "theID"),
                            new XElement("Meta",
                                new XAttribute("name", "ATTRIBUTE"),
                                new XAttribute("format", "string"),
                                "PRODUCTION_NUMBER"),
                            new XElement("Meta",
                               new XAttribute("name", "SEARCHSTRING"),
                               new XAttribute("format", "string"),
                               "91S06"),
                            new XElement("Meta",
                               new XAttribute("name", "GROUP"),
                               new XAttribute("format", "string"),
                               "1")
                            )
                       );
            return queryDoc.ToString();
        }
    }
}