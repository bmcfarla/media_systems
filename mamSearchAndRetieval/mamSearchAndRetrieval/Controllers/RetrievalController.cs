using mamSearchAndRetrieval.Models;
using ShoppingCart.Models;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    public class RetrievalController : AppController
    {
        // GET: Retrieval
        public ActionResult Details(string dmguid, string token)
        {
            RetrievalModel retrievalModel = new RetrievalModel(dmguid, token);

            return View(retrievalModel);
        }

        public ActionResult DownloadSelect(CartIdModel cartId)
        {
            ShoppingCartModel cart = ShoppingCartModel.getCart(cartId);
            List<DownloadPlaylistItems> playlistItems = cart.GetCartItemsForDownload();

            //List<PlaylistItems> playlistItems = new List<PlaylistItems>();
            //playlistItems.Add(new PlaylistItems { DmGuid = "V_99N99999_I0", MainTitle = "99N99999_0000" });
            //playlistItems.Add(new PlaylistItems { DmGuid = "V_99N99990_I0", MainTitle = "99N99990_0000" });

            ViewBag.token = CurrentUser.Token;
            return View(playlistItems);
        }

        // GET: Retrieval
        public ActionResult Download()
        {

            return View();
        }
    }
}