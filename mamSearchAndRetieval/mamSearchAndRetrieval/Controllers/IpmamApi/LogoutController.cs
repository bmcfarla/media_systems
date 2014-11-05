using mamSearchAndRetrieval.Models.Ipmam.Services;
using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    public class LogoutController : ApiController
    {
        umModel um = umModel.Instance;
    
        // GET api/<controller>?token=<token>
        public void Get([ModelBinder] string token) {
            //um.RefreshSession(token);
            try
            {
                um.Logout(token);
            }
            catch (Exception)
            {
                // Silence
            }
        }
    }
}
