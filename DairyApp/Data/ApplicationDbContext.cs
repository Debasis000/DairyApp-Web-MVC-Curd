using DairyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<DairyEntry> DairyEntrys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DairyEntry>().HasData(
                new DairyEntry { Id = 1, Title = "Went Hiking", Content="Went Hiking with Joe!", Created = DateTime.Now },
                new DairyEntry { Id = 2, Title = "Went Shopping", Content = "Went Shopping  with Shopping!", Created = DateTime.Now },
                new DairyEntry { Id = 3, Title = "Went Diving", Content = "Went Diving  with Diving!", Created = DateTime.Now }
                );
        }
    }
}
