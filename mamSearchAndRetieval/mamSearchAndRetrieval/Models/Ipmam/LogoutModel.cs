using System.Security.Claims;
using System.Web;

namespace mamSearchAndRetrieval.Ipmam
{
    public class LogoutModel
    {
        public string token { get; set; }

        internal void logout(System.Web.HttpRequestBase Request)
        {

            var IpmamApiLogoutController = new Controllers.IpmamApi.LogoutController();
            IpmamApiLogoutController.Get(token);

            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
        }
    }
}
