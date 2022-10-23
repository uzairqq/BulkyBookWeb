using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class BulkyBookDbContext : DbContext
    {
        public BulkyBookDbContext(DbContextOptions<BulkyBookDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
