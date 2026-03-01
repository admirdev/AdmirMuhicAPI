using AdmirMuhicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmirMuhicAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Home> Home { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Home>().HasData(new Home
            {
                Id = 1,
                GeneralInfo = "Fullstack-utvecklare med fokus på .NET-ekosystemet och moderna frontend-ramverk. Erfarenhet av att bygga allt från komplexa intranät för offentlig sektor till kundanpassade affärssystem."
            });
        }
    }
}