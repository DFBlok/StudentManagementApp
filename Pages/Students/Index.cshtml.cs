using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagementApp.Data;

namespace StudentManagementApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentDbContext _context;

        public IndexModel(StudentDbContext context)
        {
            _context = context;
        }

        public List<Student> students { get; set; }

        public async Task OnGetAsync()
        {
            students = await _context.students.ToListAsync();
        }
    }
}
