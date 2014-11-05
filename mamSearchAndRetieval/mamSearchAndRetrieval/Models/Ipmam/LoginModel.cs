using System.Security.Claims;
using System.Web;

namespace mamSearchAndRetrieval.Models.Ipmam
{
    public class LoginModel
    {
        public string user { get; set; }
        public string pwd { get; set; }

        internal static bool login(Models.LogInModel model, HttpRequestBase Request)
        {
            LoginModel loginModel = new LoginModel
            {
                user = model.Username,
                pwd = model.Password,
            };

            var IpmamLoginController = new Controllers.IpmamApi.LoginController();
            string token = IpmamLoginController.Get(loginModel);

            if (token != "")
            {
                storeUserInformation(loginModel.user, token, Request);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static void storeUserInformation(string user, string token, HttpRequestBase Request)
        {

            var identity = new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Authentication, token)    
                },
                "ApplicationCookie");

            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignIn(identity);
        }
    }
}