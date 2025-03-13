using Microsoft.EntityFrameworkCore;
using BookLibraryManagement.Models;

namespace BookLibraryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> FreeEBooks { get; set; }  // Legger til tabellen for bøker

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=BookLibrary.db"); // SQLite-fil i prosjektmappen
            }
        }
    }
}
