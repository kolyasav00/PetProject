using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableTasks
{
    public class DeleteModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public DeleteModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TableTasks TableTasks { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.tableTasks == null)
            {
                return NotFound();
            }

            var tabletasks = await _context.tableTasks.FirstOrDefaultAsync(m => m.Id == id);

            if (tabletasks == null)
            {
                return NotFound();
            }
            else 
            {
                TableTasks = tabletasks;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.tableTasks == null)
            {
                return NotFound();
            }
            var tabletasks = await _context.tableTasks.FindAsync(id);

            if (tabletasks != null)
            {
                TableTasks = tabletasks;
                _context.tableTasks.Remove(TableTasks);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
