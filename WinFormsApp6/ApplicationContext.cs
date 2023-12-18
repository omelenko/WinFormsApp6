using Microsoft.EntityFrameworkCore;

namespace WinFormsApp6
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Studio> Studios => Set<Studio>();
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = databasegames.db");
        }
    }
}
