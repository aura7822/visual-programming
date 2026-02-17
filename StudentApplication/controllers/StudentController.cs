using Microsoft.AspNetCore.Mvc;
using StudentApplication.Models;
using StudentApplication.Data;
namespace StudentApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        // Show Form
        public IActionResult Apply()
        {
            return View();
        }
        // Save Student to Database
        [HttpPost]
        
 public IActionResult Apply(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Details", new { id = student.Id });
        }
        // Display Saved Student
        public IActionResult Details(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }
    }
}