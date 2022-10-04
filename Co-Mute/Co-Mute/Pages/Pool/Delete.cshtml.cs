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
    public class DeleteModel : PageModel
    {
        private readonly Co_Mute.Data.PoolDatabase _context;

        public DeleteModel(Co_Mute.Data.PoolDatabase context)
        {
            _context = context;
        }

        [BindProperty]
      public AvailablePool AvailablePool { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AvailablePool == null)
            {
                return NotFound();
            }

            var availablepool = await _context.AvailablePool.FirstOrDefaultAsync(m => m.AvailablePoolId == id);

            if (availablepool == null)
            {
                return NotFound();
            }
            else 
            {
                AvailablePool = availablepool;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.AvailablePool == null)
            {
                return NotFound();
            }
            var availablepool = await _context.AvailablePool.FindAsync(id);

            if (availablepool != null)
            {
                AvailablePool = availablepool;
                _context.AvailablePool.Remove(AvailablePool);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
