using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastucture.Data
{
    public class TuckShopContext : DbContext
    {
        public TuckShopContext(DbContextOptions<TuckShopContext> options) : base
        (options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}