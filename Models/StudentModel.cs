using System.ComponentModel.DataAnnotations;

namespace Studentmanagementsystem.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public virtual ICollection<StudentCourseModel>? StudentCourses { get; set; }
    }
    
}
