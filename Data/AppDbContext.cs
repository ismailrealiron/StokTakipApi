using Microsoft.EntityFrameworkCore;
using StokTakipApi.Entities;

namespace StokTakipApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products => Set<Product>();
    }
}
