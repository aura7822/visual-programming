using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentApplication.Data;
using StudentApplication.Models;

namespace StudentApplication.Pages
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; } = new List<Student>();

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}