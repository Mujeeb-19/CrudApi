using Microsoft.EntityFrameworkCore;
using CrudApi.Models;

namespace CrudApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } = null!;
    }
}
