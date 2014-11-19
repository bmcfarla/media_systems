﻿using mamSearchAndRetrieval.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        CartsEntities db = new CartsEntities();
        
        // GET: ShoppingCart
        public ActionResult Index(CartIdModel CartId)
        {
            if (CartId.user == null || CartId.token == null)
            {
                CartId.user = "testUser";
                CartId.token = "testUserToken";
            }

            ShoppingCartModel myCart = ShoppingCartModel.getCart(CartId);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = myCart.GetCartItems()
                //CartTotal = cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }

        //
        // GET: /ShoppingCart/AddToCart?user=<user>&token=<token>&dmguid=<dmguid>
        public ActionResult AddToCart(CartIdModel cartId, string dmGuid, string mainTitle)
        {
            // Add it to the shopping cart
            ShoppingCartModel cart = ShoppingCartModel.getCart(cartId);

            cart.AddToCart(dmGuid, mainTitle);
            
            // Go back to the main store page for more shopping
            return RedirectToAction("Index",cartId);
        }

        public ActionResult Count(CartIdModel cartId)
        {
            // Add it to the shopping cart
            ShoppingCartModel cart = ShoppingCartModel.getCart(cartId);

            int count = cart.getCount();

            // Go back to the main store page for more shopping
            return Json(count, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(CartIdModel cartId, string dmGuid, string mainTitle)
        {
            // Add it to the shopping cart
            ShoppingCartModel cart = ShoppingCartModel.getCart(cartId);

            cart.AddToCart(dmGuid, mainTitle);

            // Go back to the main store page for more shopping
            return Json(cart,JsonRequestBehavior.AllowGet);
        }

        public ActionResult remove(CartIdModel cartId, string dmGuid)
        {
            // Add it to the shopping cart
            ShoppingCartModel cart = ShoppingCartModel.getCart(cartId);

            cart.RemoveFromCart(dmGuid);

            // Go back to the main store page for more shopping
            return Json(cart, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RemoveFromCart(CartIdModel cartId, string dmGuid)
        {
            // Remove the item from the cart
            var cart = ShoppingCartModel.getCart(cartId);
            
            // Remove from cart. Note that for simplicity, we're 
            // removing all rather than decrementing the count.
            cart.RemoveFromCart(dmGuid);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {
                Message = dmGuid + " has been removed from your shopping cart."
            };

            return Json(results, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EmptyCart(CartIdModel cartId)
        {
            // Remove the item from the cart
            var cart = ShoppingCartModel.getCart(cartId);

            // Remove from cart. Note that for simplicity, we're 
            // removing all rather than decrementing the count.
            cart.EmptyCart();

            return Json(cart, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetItems(CartIdModel cartId)
        {
            // Add it to the shopping cart
            ShoppingCartModel cart = ShoppingCartModel.getCart(cartId);

            List<string> items = cart.GetCartItems();

            SimpleSearchModel search = new SimpleSearchModel
            {
                searchString = string.Join("|", items)
            };

            TempData["cartSearch"] = search;

            // Go back to the main store page for more shopping
            return RedirectToAction("index","Results");
        }
    }
}