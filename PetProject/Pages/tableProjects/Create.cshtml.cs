using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableProjects
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
        public TableProjects tableProjects { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.tableProjects == null || tableProjects == null)
            {
                return Page();
            }

            _context.tableProjects.Add(tableProjects);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
