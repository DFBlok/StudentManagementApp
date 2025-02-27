using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagementApp.Data;

namespace StudentManagementApp.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly StudentDbContext _context;
        public EditModel(StudentDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _context.students.FindAsync(id);
            if(Student == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.students.Update(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }

}
