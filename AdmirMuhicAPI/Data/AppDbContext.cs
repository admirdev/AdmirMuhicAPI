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
        public DbSet<Project> Projects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Home>().HasData(new Home
            {
                Id = 1,
                GeneralInfo = "Fullstack-utvecklare med fokus på .NET-ekosystemet och moderna frontend-ramverk. Erfarenhet av att bygga allt från komplexa intranät för offentlig sektor till kundanpassade affärssystem."
            });

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Title = "Olofströms Ishockeyklubb",
                    Description = "Hemsida för Olofströms IK, utvecklad i Wordpress. Projektet fokuserade på att skapa en användarvänlig plattform för supportrar och medlemmar.",
                    Image = "https://iili.io/BmNG5Cb.png",
                    Tags = "Wordpress",
                    Link = "https://www.oik.se"
                },
                new Project
                {
                    Id = 2,
                    Title = "Lorem ipsum dolor sit amet",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    Image = "https://wearereeds.co.uk/assets/images/transforms/Insights/_1920x900_crop_center-center_none/35873/lorem-ipsum.avif",
                    Tags = ".NET,Vue.js,SQL,Bootstrap",
                    Link = "https://www.lipsum.com/"
                }
            );
        }
    }
}