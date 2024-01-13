using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetProject.Areas.Identity;
using PetProject.Data;

namespace PetProject.Pages.tableEmployees
{
    public class DetailsModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public DetailsModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public TableEmployees TableEmployees { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.tableEmployees == null)
            {
                return NotFound();
            }

            var tableemployees = await _context.tableEmployees.FirstOrDefaultAsync(m => m.Id == id);
            if (tableemployees == null)
            {
                return NotFound();
            }
            else 
            {
                TableEmployees = tableemployees;
            }
            return Page();
        }
    }
}
