using System.Security.Claims;

namespace mamSearchAndRetrieval.Models
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal) : base(principal)
        {
        }

        public string Name
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Token
        {
            get
            {
                return this.FindFirst(ClaimTypes.Authentication).Value;
            }
        }
    }
}