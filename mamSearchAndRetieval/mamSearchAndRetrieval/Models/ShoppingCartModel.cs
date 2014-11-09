using mamSearchAndRetrieval.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShoppingCart.Models
{
    class ShoppingCartModel
    {
        CartsEntities db = new CartsEntities();
        public string CartSessionKey = "CartId";
        public int shoppingCartId { get; set; }

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

        public void AddToCart(string dmGuid)
        {
            var item = db.Items.SingleOrDefault(c => c.DmGuid == dmGuid && c.CartId == shoppingCartId);

            if (item == null)
            {
                // Create a new cart item
                item = new Item
                {
                    CartId = shoppingCartId,
                    DmGuid = dmGuid
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
        }

        internal List<Cart> GetCartItems()
        {
            var cartItems = (from cart in db.Carts
                             where cart.CartId == shoppingCartId
                             select cart).ToList();
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
        }

        public void EmptyCart()
        {
            var cartItems = db.Items.Where(cart => cart.CartId == shoppingCartId);

            foreach (var cartItem in cartItems)
            {
                db.Items.Remove(cartItem);
            }
            db.SaveChanges();
        }
    }
}
