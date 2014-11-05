using mamSearchAndRetrieval.Ipmam;
using mamSearchAndRetrieval.Models;
using mamSearchAndRetrieval.Models.Ipmam;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    [AllowAnonymous]
    public class AuthController : AppController
    {
        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            LogInModel model = new LogInModel
            {
                ReturnUrl = returnUrl
            };

            return View("LogIn", model);
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (LoginModel.login(model, Request))
            {
                if (model.ReturnUrl != null)
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Simple", "Search");
                }
            }
            else
            {
                // user auth failed
                ModelState.AddModelError("", "Invalid Username or password");
                return View(model);
            }
        }
            

        public ActionResult LogOut()
        {
            LogoutModel model = new LogoutModel { token = this.CurrentUser.Token };

            model.logout(Request);

            return RedirectToAction("Login", "Auth");
        }
    }
}