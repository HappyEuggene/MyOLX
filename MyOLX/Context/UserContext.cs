using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyOLX.Models;

namespace MyOLX.Context
{
    public class UserContext: IdentityDbContext<Users>
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {
           
        }
    }
}
