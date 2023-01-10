using Microsoft.EntityFrameworkCore;
using ShopCart.Web.Models;

namespace ShopCart.Web.infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
