using Microsoft.EntityFrameworkCore;
using BattleGameAPI.Models;

namespace BattleGameAPI.Data
{
    public class BattleGameDbContext : DbContext
    {
        public BattleGameDbContext(DbContextOptions<BattleGameDbContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<PlayerAsset> PlayerAssets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerAsset>()
                .HasKey(pa => new { pa.PlayerId, pa.AssetId });
        }
    }
}