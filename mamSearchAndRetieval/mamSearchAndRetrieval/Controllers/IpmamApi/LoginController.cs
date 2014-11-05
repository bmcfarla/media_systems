using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models.Ipmam.Services;
using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace mamSearchAndRetrieval.Controllers.IpmamApi
{
    public class LoginController : ApiController
    {
        umModel um = umModel.Instance;

        // GET api/<controller>/<user>/<pwd>
        public string Get([ModelBinder] LoginModel loginModel)
        {
            string token = "";
            string user = loginModel.user;
            string pwd = loginModel.pwd;

            try
            {
                token = um.Login(user, pwd);
            }
            catch
            {

                return "";
            }

            return token;
        }

        // POST api/<controller>
        public string Post([FromBody]LoginModel loginModel)
        {
            string token = "";
            string user = loginModel.user;
            string pwd = loginModel.pwd;

            try
            {
                token = um.Login(user, pwd);
            }
            catch (Exception)
            {

                throw;
            }

            return token;
        }
    }
}