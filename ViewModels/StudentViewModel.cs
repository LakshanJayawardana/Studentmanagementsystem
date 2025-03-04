using Microsoft.AspNetCore.Mvc.Rendering;

namespace Studentmanagementsystem.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<Courses> Courses { get; set; }  // List of courses for the student
        public List<SelectListItem> AvailableCourses { get; set; }  // List of courses to select from
    }
}
