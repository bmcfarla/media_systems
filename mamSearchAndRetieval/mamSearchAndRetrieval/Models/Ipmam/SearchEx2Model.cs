using mamSearchAndRetrieval.Controllers.IpmamApi;
using mamSearchAndRetrieval.Models.Ipmam.Resources;

namespace mamSearchAndRetrieval.Models.Ipmam
{
    public class SearchEx2Model : SearchEx2IpmamModel
    {
        public string search()
        {
            SearchEx2Controller SearchEx2 = new SearchEx2Controller();
            string results = SearchEx2.Get(this);

            return results;


            /*
            SearchEx2IpmamModel model = new SearchEx2IpmamModel()
                {
                    accessKey = this.token,
                    queryDoc = getQueryDoc(),
                    hitlistDoc = getHitlistDoc(),
                    language = "en"
                };

            var SearchEx2 = new SearchEx2Controller();
            string results = SearchEx2.Get(model);
            
            return results;
            */
        }
        /*
        private string getHitlistDoc()
        {
            return AxfModel.hitlistDoc(this);
        }

        private string getQueryDoc()
        {
            return AxfModel.simpleSeachQueryDoc(this);
        }
        */
    }
}
