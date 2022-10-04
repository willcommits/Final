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
    public class DetailsModel : PageModel
    {
        private readonly Co_Mute.Data.CarData _context;

        public DetailsModel(Co_Mute.Data.CarData context)
        {
            _context = context;
        }

      public Carpool Carpool { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Carpool == null)
            {
                return NotFound();
            }

            var carpool = await _context.Carpool.FirstOrDefaultAsync(m => m.CarpoolID == id);
            if (carpool == null)
            {
                return NotFound();
            }
            else 
            {
                Carpool = carpool;
            }
            return Page();
        }
    }
}
