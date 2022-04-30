using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Models
{
    public class ECommerceContext: IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       
       
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }
    }
}
