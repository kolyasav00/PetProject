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
    public class IndexModel : PageModel
    {
        private readonly PetProject.Data.ApplicationDbContext _context;

        public IndexModel(PetProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TableEmployees> TableEmployees { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.tableEmployees != null)
            {
                TableEmployees = await _context.tableEmployees.ToListAsync();
            }
        }
    }
}
