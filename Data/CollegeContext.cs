using Microsoft.EntityFrameworkCore;
using CollegeManagementSystem.Models;

namespace CollegeManagementSystem.Data
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
    }
}
