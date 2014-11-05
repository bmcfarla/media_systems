using mamSearchAndRetrieval.Models;
using System.Security.Claims;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    /// <summary>
    /// This class add global resources
    /// </summary>
    public abstract class AppController : Controller
    {
        public AppUser CurrentUser
        {
            get
            {
                return new AppUser(this.User as ClaimsPrincipal);
            }
        }
    }
}