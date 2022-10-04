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
    public class DetailsModel : PageModel
    {
        private readonly Co_Mute.Data.Trip _context;

        public DetailsModel(Co_Mute.Data.Trip context)
        {
            _context = context;
        }

      public User Users { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Users = await _context.User
                .Include(s => s.Carpools)
                .ThenInclude(e => e.AvailablePool)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Users == null)
            {
                return NotFound();
            }
            return Page();
        }

        private IActionResult View(User users)
        {
            throw new NotImplementedException();
        }
    }
}
