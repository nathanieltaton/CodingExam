using Microsoft.EntityFrameworkCore;

namespace TestChallenge.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Total> Totals { get; set; }
    }
}
