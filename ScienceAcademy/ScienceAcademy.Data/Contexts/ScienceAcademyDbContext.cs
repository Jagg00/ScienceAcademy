using Microsoft.EntityFrameworkCore;
using ScienceAcademy.Data.Entities;

namespace ScienceAcademy.Data.Contexts
{
    public class ScienceAcademyDbContext : DbContext
    {
        public ScienceAcademyDbContext()
        {
            
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Pass the connection string here
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=ScienceAcademy; Trusted_Connection=True; TrustServerCertificate=true;");
            }
        }
    }
}
