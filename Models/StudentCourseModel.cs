using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studentmanagementsystem.Models
{
    public class StudentCourseModel
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("StudentId")]
        public virtual StudentModel? Student { get; set; }
        [ForeignKey("CourseId")]
        public virtual CourseModel? Course { get; set; }
    }
}
