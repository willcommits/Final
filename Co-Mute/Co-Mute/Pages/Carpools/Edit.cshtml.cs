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

namespace Co_Mute.Pages.Carpools
{
    public class EditModel : PageModel
    {
        private readonly Co_Mute.Data.CarData _context;

        public EditModel(Co_Mute.Data.CarData context)
        {
            _context = context;
        }

        [BindProperty]
        public Carpool Carpool { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Carpool == null)
            {
                return NotFound();
            }

            var carpool =  await _context.Carpool.FirstOrDefaultAsync(m => m.CarpoolID == id);
            if (carpool == null)
            {
                return NotFound();
            }
            Carpool = carpool;
           ViewData["UserID"] = new SelectList(_context.Set<User>(), "ID", "Email");
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

            _context.Attach(Carpool).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarpoolExists(Carpool.CarpoolID))
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

        private bool CarpoolExists(int id)
        {
          return _context.Carpool.Any(e => e.CarpoolID == id);
        }
    }
}
