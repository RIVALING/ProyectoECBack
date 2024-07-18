using Microsoft.EntityFrameworkCore;
using PruebaEC.Models;

namespace PruebaEC.Context
{
    public class AppECDBContext: DbContext
    {
        //Constructor
        public AppECDBContext(DbContextOptions<AppECDBContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

    }
}
