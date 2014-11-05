using System.Xml.Linq;

namespace mamSearchAndRetrieval.Models.Ipmam.Resources
{
    public class AxfModel
    {
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
    }
}