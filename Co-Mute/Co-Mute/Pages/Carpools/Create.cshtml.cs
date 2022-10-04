using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Co_Mute.Data;
using Co_Mute.Models;

namespace Co_Mute.Pages.Carpools
{
    public class CreateModel : PageModel
    {
        private readonly Co_Mute.Data.CarData _context;

        public CreateModel(Co_Mute.Data.CarData context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserID"] = new SelectList(_context.Set<User>(), "ID", "Email");
            return Page();
        }

        [BindProperty]
        public Carpool Carpool { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Carpool.Add(Carpool);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
