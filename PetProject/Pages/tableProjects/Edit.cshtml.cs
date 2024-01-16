using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableProjects
{
    public class EditModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public EditModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TableProjects tableProjects { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TableProjects == null)
            {
                return NotFound();
            }

            var tableprojects =  await _context.TableProjects.FirstOrDefaultAsync(m => m != null && m.Id == id);
            if (tableprojects == null)
            {
                return NotFound();
            }
            tableProjects = tableprojects;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(tableProjects).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tableProjectsExists(tableProjects.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool tableProjectsExists(int id)
        {
          return (_context.TableProjects?.Any(e => e != null && e.Id == id)).GetValueOrDefault();
        }
    }
}
