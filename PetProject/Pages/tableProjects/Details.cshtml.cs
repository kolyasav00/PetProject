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
    public class DetailsModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public DetailsModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public TableProjects tableProjects { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TableProjects == null)
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
                tableProjects = tableprojects;
            }
            return Page();
        }
    }
}
