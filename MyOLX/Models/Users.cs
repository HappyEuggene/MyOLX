using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;

namespace MyOLX.Models
{
    public class Users: IdentityUser
    {
        public string Name { get; set; }

        public string LastName { get; set; }
        
    }
}
    