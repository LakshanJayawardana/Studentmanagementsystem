using Microsoft.AspNetCore.Mvc;
using RestSharp;
using Studentmanagementsystem.Data;

namespace Studentmanagementsystem.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var student = _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (student != null)
            {
                return RedirectToAction("Index", "Student");
            }
            ViewBag.Message = "Invalid username or password";
            return View();
        }
    }
}
