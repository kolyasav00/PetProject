using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PetProject.Pages
{
    /// <inheritdoc />
    [Authorize]
    public class IndexModel : PageModel
    {
        public IndexModel(ILogger<IndexModel> logger)
        {
        }

        public void OnGet()
        {
            // Method intentionally left empty.
        }
    }
}
