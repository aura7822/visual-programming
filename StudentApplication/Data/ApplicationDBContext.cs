using Microsoft.EntityFrameworkCore;
using StudentApplication.Models;

namespace StudentApplication.Data
{
    public class ApplicationDbContext : DbContext  // Fixed: Changed from ApplicationDBContext to ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}