using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableTasks
{
    public class CreateModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public CreateModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TableTasks TableTasks { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.tableTasks == null || TableTasks == null)
            {
                return Page();
            }

            _context.tableTasks.Add(TableTasks);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
