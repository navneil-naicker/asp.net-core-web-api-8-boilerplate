using Microsoft.AspNetCore.Identity;

namespace asp.net_core_web_api_8_boilerplate.Data.Entities
{
    public class User : IdentityUser
    {
        public required string FullName { get; set; }
    }
}
