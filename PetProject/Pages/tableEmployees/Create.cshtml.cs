using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableEmployees
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
        public TableEmployees? TableEmployees { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.TableEmployees == null || TableEmployees == null)
            {
                return Page();
            }

            _context.TableEmployees.Add(TableEmployees);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
