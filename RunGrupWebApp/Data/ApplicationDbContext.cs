using Microsoft.EntityFrameworkCore;
using RunGrupWebApp.Models;

namespace RunGrupWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Adresses { get; set; }
    }
}
