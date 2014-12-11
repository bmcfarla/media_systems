using mamSearchAndRetrieval.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShoppingCart.Models
{
    public class ShoppingCartModel
    {
        CartsEntities db = new CartsEntities();
        public string CartSessionKey = "CartId";
        public int shoppingCartId { get; set; }
        public int count { get; set; }

        internal static ShoppingCartModel getCart(CartIdModel cartId)
        {

            ShoppingCartModel cart = new ShoppingCartModel();
            cart.shoppingCartId = cart.GetCartId(cartId);

            return cart;
        }

        private int GetCartId(CartIdModel CartId)
        {
            var user = db.Users.SingleOrDefault(c => c.Username == CartId.user);

            if (user == null)
            {
                // Create a new cart item
                user = new User
                {
                    Username = CartId.user
                };

                db.Users.Add(user);

                // Save it
                db.SaveChanges();
            }

            var cart = db.Carts.SingleOrDefault(c => c.UsersId == user.Id && c.Guid == CartId.token);

            if (cart == null)
            {
                // Create a new cart item
                cart = new Cart
                {
                    UsersId = user.Id,
                    Guid = CartId.token
                };

                db.Carts.Add(cart);

                // Save it
                db.SaveChanges();

            }

            return cart.CartId;
        }

        public void AddToCart(string dmGuid, string mainTitle)
        {
            var item = db.Items.SingleOrDefault(c => c.DmGuid == dmGuid && c.CartId == shoppingCartId);

            if (item == null)
            {
                // Create a new cart item
                item = new Item
                {
                    CartId = shoppingCartId,
                    DmGuid = dmGuid,
                    MainTitle = mainTitle
                };

                db.Items.Add(item);
            }
            else
            {
                // Add one to the quantity
                //item.Count++;
            }

            // Save it
            db.SaveChanges();

            count = db.Items.Count(c => c.CartId == shoppingCartId);
        }

        internal List<DownloadPlaylistItems> GetCartItemsForDownload()
        {
            List<DownloadPlaylistItems> cartItems = new List<DownloadPlaylistItems>();

            var returnItems = (from items in db.Items
                               where items.CartId == shoppingCartId
                               select new { items.DmGuid, items.MainTitle }).ToList();

            foreach (var item in returnItems)
            {
                cartItems.Add(
                    new DownloadPlaylistItems
                    {
                        DmGuid = item.DmGuid,
                        MainTitle = item.MainTitle
                    }
                );
            }
            return cartItems;

        }

        internal List<string> GetCartItemsMainTitle()
        {
            var cartItems = (from items in db.Items
                             where items.CartId == shoppingCartId
                             select items.MainTitle).ToList();
            return cartItems;

        }

        internal void RemoveFromCart(string dmGuid)
        {
            var item = db.Items.Single(c => c.DmGuid == dmGuid && c.CartId == shoppingCartId);

            if (item != null)
            {
                // Remove cart item
                db.Items.Remove(item);

                // Save it
                db.SaveChanges();
            }

            count = db.Items.Count(c => c.CartId == shoppingCartId);
        }

        public void EmptyCart()
        {
            var cartItems = db.Items.Where(cart => cart.CartId == shoppingCartId);

            foreach (var cartItem in cartItems)
            {
                db.Items.Remove(cartItem);
            }
            db.SaveChanges();
            count = db.Items.Count(c => c.CartId == shoppingCartId);
        }

        internal int getCount()
        {
            return db.Items.Count(c => c.CartId == shoppingCartId);
        }
    }
}
