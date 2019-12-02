using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyWebsite.Pages
{
    public class MusicModel : PageModel
    {
        private readonly ILogger<MusicModel> _logger;

        public MusicModel(ILogger<MusicModel> logger)
        {
            _logger = logger;
        }
        public IActionResult OnGet()
        {
            return RedirectToPage("./Musics/Index");
        }
    }
}