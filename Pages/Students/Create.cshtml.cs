using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagementApp.Data;

namespace StudentManagementApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentDbContext _context;

        [BindProperty]
        public Student Student { get; set; }

        public CreateModel(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.students.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
