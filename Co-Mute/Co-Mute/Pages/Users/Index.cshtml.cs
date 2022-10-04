using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Co_Mute.Data;
using Co_Mute.Models;

namespace Co_Mute.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Co_Mute.Data.Trip _context;

        public IndexModel(Co_Mute.Data.Trip context)
        {
            _context = context;
        }

        public IList<User> Users { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                Users = await _context.User.ToListAsync();
            }
        }
    }
}
