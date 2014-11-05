namespace mamSearchAndRetrieval.Models
{
    public class SimpleSearchModel
    {
        public string searchString { get; set; }
        public string firstHit { get; set; }
        public string maxHits { get; set; }


        public SimpleSearchModel()
        {
            firstHit = "0";
            maxHits = "15";
        }
    }
}