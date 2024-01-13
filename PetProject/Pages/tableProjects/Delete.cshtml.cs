using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableProjects
{
    public class DeleteModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public DeleteModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TableProjects tableProjects { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.tableProjects == null)
            {
                return NotFound();
            }

            var tableprojects = await _context.tableProjects.FirstOrDefaultAsync(m => m.Id == id);

            if (tableprojects == null)
            {
                return NotFound();
            }
            else 
            {
                tableProjects = tableprojects;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.tableProjects == null)
            {
                return NotFound();
            }
            var tableprojects = await _context.tableProjects.FindAsync(id);

            if (tableprojects != null)
            {
                tableProjects = tableprojects;
                _context.tableProjects.Remove(tableProjects);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
