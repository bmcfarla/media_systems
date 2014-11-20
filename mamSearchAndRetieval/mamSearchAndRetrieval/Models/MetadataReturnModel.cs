using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mamSearchAndRetrieval.Models
{
    public class MetadataReturnModel
    {
        public Dictionary<string, string> items { get; set; }
        public Dictionary<string,List<Dictionary<string, string>>> MvAttributeItems { get; set; }
    }
}
