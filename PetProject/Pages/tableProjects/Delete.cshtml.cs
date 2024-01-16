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
      public TableProjects? TableProjects { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableprojects = await _context.TableProjects.FirstOrDefaultAsync(m => m != null && m.Id == id);

            if (tableprojects == null)
            {
                return NotFound();
            }
            else 
            {
                TableProjects = tableprojects;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TableProjects == null)
            {
                return NotFound();
            }
            var tableprojects = await _context.TableProjects.FindAsync(id);

            if (tableprojects != null)
            {
                TableProjects = tableprojects;
                _context.TableProjects.Remove(TableProjects);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
