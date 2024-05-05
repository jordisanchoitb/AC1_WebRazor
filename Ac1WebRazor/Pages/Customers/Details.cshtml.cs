using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ac1WebRazor.Data;
using Ac1WebRazor.Models;

namespace Ac1WebRazor.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly Ac1WebRazor.Data.Ac1WebRazorContext _context;

        public DetailsModel(Ac1WebRazor.Data.Ac1WebRazorContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                Customer = customer;
            }
            return Page();
        }
    }
}
