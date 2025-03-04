using System.ComponentModel.DataAnnotations;

namespace Studentmanagementsystem.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<StudentCourseModel>? StudentCourses { get; set; }
    }
}
