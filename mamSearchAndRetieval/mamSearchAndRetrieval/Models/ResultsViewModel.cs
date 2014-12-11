using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Resources;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace mamSearchAndRetrieval.Models
{
    public class ResultsViewModel
    {
        private SimpleSearchModel model;
        
        // Properties
        public List<ResultsItemModel> resultsItems { get; set; }
        public PagerModel pager { get; set; }
        public SearchEx2Model searchEx2Model { get; set; }
        public ShoppingCartModel cart { get; set; }
        public string user { get; set; }
        public string token { get; set; }
        public string searchString { get; set; }
        public AdvancedSearchViewModel advancedSearchQuery { get; set; }
        public int playlistItemCount { get; set; }

        public ResultsViewModel(AdvancedSearchViewModel model, AppUser appUser)
        {
            this.token = appUser.Token;
            this.user = appUser.Name;

            AxfModel Axf = new AxfModel();

            searchEx2Model = new SearchEx2Model
            {
                accessKey = this.token,
                queryDoc = Axf.advancedSeachQueryDoc(model),
                hitlistDoc = Axf.hitlistDoc(),
                language = "en"
            };

            advancedSearchQuery = model;
            searchString = "";

            pager = new PagerModel
            {
                hitsPerPage = Convert.ToInt32(model.maxHits),
                firstHit = Convert.ToInt32(model.firstHit),
                maxHits = Convert.ToInt32(model.maxHits),
                pages = 1
            };

            AddCart();

            resultsItems = getResultsItems();
        }

        // Constructor
        public ResultsViewModel(SimpleSearchModel model, AppUser appUser)
        {
            this.token = appUser.Token;
            this.user = appUser.Name;
            
            AxfModel Axf = new AxfModel();

            searchEx2Model = new SearchEx2Model
            {
                accessKey = this.token,
                queryDoc = Axf.simpleSeachQueryDoc(model),
                hitlistDoc = Axf.hitlistDoc(),
                language = "en"
            };

            advancedSearchQuery = null;
            searchString = model.searchString;

            pager = new PagerModel
            {
                hitsPerPage = Convert.ToInt32(model.maxHits),
                firstHit = Convert.ToInt32(model.firstHit),
                maxHits = Convert.ToInt32(model.maxHits),
                pages = 1
            };

            AddCart();
            
            resultsItems = getResultsItems();
        }

        
        // Get Results based of search string
        private List<ResultsItemModel> getResultsItems()
        {
            string axfResults = this.searchEx2Model.search();

            // Create and XML doc
            XmlDocument doc = new XmlDocument();

            // Load XML doc
            doc.LoadXml(axfResults);

            // Convert XML Doc to XML Nodes
            XmlNode root = doc.DocumentElement;

            // Extract number of hits from the AXF
            XmlNodeList numberOfHits = root.SelectNodes("//MAObject[@type='QueryResult']/Meta[@name='NUMBEROFHITS']");

            // Initialize the pager with the number of hits
            this.pager.totalRecords = Convert.ToInt32(numberOfHits[0].InnerText);
            Decimal a = System.Math.Ceiling((Decimal)1210 / 16);

            this.pager.pages = System.Math.Ceiling((Decimal)this.pager.totalRecords / this.pager.hitsPerPage);

            // Extract dmGuids from the AXF
            XmlNodeList dmGuids = root.SelectNodes("//MAObject[@mdclass='VIDEO']/GUID");

            //ResultsItemsModel gridItems = new ResultsItemsModel();
            List<ResultsItemModel> resultsItems = new List<ResultsItemModel>();
            
            List<string> cartItems = cart.GetCartItemsMainTitle();
            
            playlistItemCount = cartItems.Count;

            foreach (XmlNode dmGuid in dmGuids)
            {
                // Create new gridItem
                ResultsItemModel resultsItem = new ResultsItemModel();
                resultsItem.token = this.token;

                // Extract the text of the XML object
                resultsItem.dmGuid = dmGuid.InnerText;
                resultsItem.cartSelected = cartItems.Contains(resultsItem.dmGuid);

                resultsItem.mainTitle = root.SelectNodes(string.Format("//MAObject[@mdclass='VIDEO'][GUID = '{0}']/Meta[@name='MAINTITLE']", resultsItem.dmGuid))[0].InnerText;
                
                resultsItem.getEpGuid();
                resultsItem.getThumbnailEmguid();
                resultsItem.getThumbnailUrl();

                // Add item to List
                resultsItems.Add(resultsItem);
            }

            return resultsItems;
        }

        private void AddCart()
        {
            CartIdModel cartId = new CartIdModel
            {
                user = this.user,
                token = token
            };

            cart = ShoppingCartModel.getCart(cartId);
        }

    }
}
