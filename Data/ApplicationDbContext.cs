using Microsoft.EntityFrameworkCore;
using Studentmanagementsystem.Models;

namespace Studentmanagementsystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CourseModel>? Courses { get; set; }
        public DbSet<StudentCourseModel>? StudentCourses { get; set; }
        public DbSet<StudentModel>? Students { get; set; }
        public DbSet<UserModel>? Users { get; set; }
    }
}
