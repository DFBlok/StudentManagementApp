using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagementApp.Data;

namespace StudentManagementApp.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly StudentDbContext _context;

        public DeleteModel(StudentDbContext context)
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
            var student = await _context.students.FindAsync(Student.ID);
            if(student == null) return NotFound();

            _context.students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
