using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyWebsite.Pages
{
    public class MovieModel : PageModel
    {
        private readonly ILogger<MovieModel> _logger;

        public MovieModel(ILogger<MovieModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return RedirectToPage("./Movies/Index");
        }
    }
}