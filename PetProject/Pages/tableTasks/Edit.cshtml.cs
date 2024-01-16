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

namespace PetProject.Pages.tableTasks
{
    public class EditModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public EditModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TableTasks TableTasks { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TableTasks == null)
            {
                return NotFound();
            }

            var tabletasks =  await _context.TableTasks.FirstOrDefaultAsync(m => m.Id == id);
            if (tabletasks == null)
            {
                return NotFound();
            }
            TableTasks = tabletasks;
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

            _context.Attach(TableTasks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableTasksExists(TableTasks.Id))
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

        private bool TableTasksExists(int id)
        {
          return (_context.TableTasks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
