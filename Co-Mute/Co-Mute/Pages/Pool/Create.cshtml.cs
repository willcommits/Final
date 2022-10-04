using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Co_Mute.Data;
using Co_Mute.Models;

namespace Co_Mute.Pages.Pool
{
    public class CreateModel : PageModel
    {
        private readonly Co_Mute.Data.PoolDatabase _context;

        public CreateModel(Co_Mute.Data.PoolDatabase context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AvailablePool AvailablePool { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AvailablePool.Add(AvailablePool);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
