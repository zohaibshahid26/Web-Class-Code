using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class MyAppUser : IdentityUser

    {

        public string City { get; set; }
        public string Country { get; set; }
    }
}
