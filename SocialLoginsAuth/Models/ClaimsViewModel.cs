using System.Collections.Generic;
using System.Security.Claims;

namespace SocialLoginsAuth.Models
{
    public class ClaimsViewModel
    {
        public IEnumerable<Claim> Claims { get; set; }

        public string Name { get; set; }
    }
}
