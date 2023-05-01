using Microsoft.EntityFrameworkCore;
using MyOLX.Models;

namespace MyOLX.Context
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options ): base(options)
        {
           
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Product> Item { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Payment> Payment { get; set; }


    }
}
