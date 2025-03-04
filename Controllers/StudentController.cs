using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentmanagementsystem.Data;
using Studentmanagementsystem.Models;

namespace Studentmanagementsystem.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var student = _context.Students.Include(s => s.StudentCourses).ToList();

            return View(student);
        }

        public ActionResult AddCourse(int courseId, int studentId)
        {
            var studentCourse = new StudentCourseModel
            {
                CourseId = courseId,
                StudentId = studentId
            };
            _context.StudentCourses.Add(studentCourse);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCourse(int courseId, int studentId)
        {
            var studentCourse = _context.StudentCourses
            .FirstOrDefault(sc => sc.StudentId == studentId && sc.CourseId == courseId);
            if (studentCourse != null)
            {
                _context.StudentCourses.Remove(studentCourse);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}
