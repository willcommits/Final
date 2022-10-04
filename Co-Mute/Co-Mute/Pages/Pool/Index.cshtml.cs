using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Co_Mute.Data;
using Co_Mute.Models;

namespace Co_Mute.Pages.Pool
{
    public class IndexModel : PageModel
    {
        private readonly Co_Mute.Data.PoolDatabase _context;

        public IndexModel(Co_Mute.Data.PoolDatabase context)
        {
            _context = context;
        }

        public IList<AvailablePool> AvailablePool { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AvailablePool != null)
            {
                AvailablePool = await _context.AvailablePool.ToListAsync();
            }
        }
    }
}
