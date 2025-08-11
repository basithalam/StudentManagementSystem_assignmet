using Microsoft.EntityFrameworkCore;
using StudentManagementSystem_assignmet.Models;

namespace StudentManagementSystem_assignmet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }

}
