using Microsoft.EntityFrameworkCore;

namespace EnergyDashboardApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<EnergyData> EnergyData { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}