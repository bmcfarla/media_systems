
namespace mamSearchAndRetrieval.Models.Ipmam.Resources
{
    public class GetDMObjectExLocalizedIpmamModel
    {
        public string axfdoc { get; set; }
        public string accesskey { get; set; }
        public bool includeAttributes { get; set; }
        public bool includeStrata { get; set; }
        public bool includeAssociations { get; set; }
        public bool includeEssencePackages { get; set; }
        public string language { get; set; }
        public string framerate { get; set; }
    }
}
