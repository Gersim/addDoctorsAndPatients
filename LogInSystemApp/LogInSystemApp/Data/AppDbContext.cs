using LogInSystemApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LogInSystemApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Patients> patients { get; set; }
    }
}
