using BMO.Api.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BMO.Api.Models
{
    public class BmodbContext : DbContext
    {
        public BmodbContext(DbContextOptions<BmodbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
        }

        //Register Sets

        public DbSet<Device> Devices { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}
