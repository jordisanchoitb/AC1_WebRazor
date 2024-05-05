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
    public class IndexModel : PageModel
    {
        private readonly Ac1WebRazor.Data.Ac1WebRazorContext _context;

        public IndexModel(Ac1WebRazor.Data.Ac1WebRazorContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var customers = from c in _context.Customer
                            select c;
            if (!string.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(s => s.CompanyName.Contains(SearchString));
            }

            Customer = await customers.ToListAsync();
        }
    }
}
