using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentApplication.Data;
using StudentApplication.Models;

namespace StudentApplication.Pages
{
    public class ApplyModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplyModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public void OnGet()
        {
            // Display empty form
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            _context.SaveChanges();

            return RedirectToPage("/List");
        }
    }
}