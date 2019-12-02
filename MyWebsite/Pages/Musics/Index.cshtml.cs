using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebsite.Models;

namespace MyWebsite.Pages.Musics
{
    public class IndexModel : PageModel
    {
        private readonly MyWebsite.Data.MyWebsiteContext _context;

        public IndexModel(MyWebsite.Data.MyWebsiteContext context)
        {
            _context = context;
        }
        public IList<Music> Music { get; set; }
        public async Task OnGetAsync()
        {
            Music = await _context.Music.ToListAsync();
        }
    }
}