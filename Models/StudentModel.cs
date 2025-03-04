namespace Studentmanagementsystem.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public Gender? Gender { get; set; }
        public virtual ICollection<StudentCourseModel>? StudentCourses { get; set; }
    }
    public class Gender
    {
        public string? GenderName { get; set; }
    }
}
