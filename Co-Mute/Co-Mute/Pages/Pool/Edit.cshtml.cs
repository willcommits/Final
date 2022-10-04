using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Co_Mute.Data;
using Co_Mute.Models;

namespace Co_Mute.Pages.Pool
{
    public class EditModel : PageModel
    {
        private readonly Co_Mute.Data.PoolDatabase _context;

        public EditModel(Co_Mute.Data.PoolDatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public AvailablePool AvailablePool { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AvailablePool == null)
            {
                return NotFound();
            }

            var availablepool =  await _context.AvailablePool.FirstOrDefaultAsync(m => m.AvailablePoolId == id);
            if (availablepool == null)
            {
                return NotFound();
            }
            AvailablePool = availablepool;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AvailablePool).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvailablePoolExists(AvailablePool.AvailablePoolId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvailablePoolExists(int id)
        {
          return _context.AvailablePool.Any(e => e.AvailablePoolId == id);
        }
    }
}
