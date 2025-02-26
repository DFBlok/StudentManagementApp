using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace StudentManagementApp.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { 
        
        }
        public DbSet<Student> students { get; set; }

    }
}
