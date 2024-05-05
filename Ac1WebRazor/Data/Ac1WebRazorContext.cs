using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ac1WebRazor.Models;

namespace Ac1WebRazor.Data
{
    public class Ac1WebRazorContext : DbContext
    {
        public Ac1WebRazorContext (DbContextOptions<Ac1WebRazorContext> options)
            : base(options)
        {
        }

        public DbSet<Ac1WebRazor.Models.Customer> Customer { get; set; } = default!;
    }
}
