using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Co_Mute.Data;
using Co_Mute.Models;

namespace Co_Mute.Pages.Carpools
{
    public class IndexModel : PageModel
    {
        private readonly Co_Mute.Data.CarData _context;

        public IndexModel(Co_Mute.Data.CarData context)
        {
            _context = context;
        }

        public IList<Carpool> Carpool { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Carpool != null)
            {
                Carpool = await _context.Carpool
                .Include(c => c.User).ToListAsync();
            }
        }
    }
}
