using Week14LastPractice.Models;
using Microsoft.EntityFrameworkCore;


namespace Week14LastPractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
