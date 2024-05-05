using Microsoft.EntityFrameworkCore;
using Ac1WebRazor.Data;

namespace Ac1WebRazor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Ac1WebRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Ac1WebRazorContext>>()))
            {
                if (context == null || context.Customer == null)
                {
                    throw new ArgumentNullException("Null Ac1WebRazorContext");
                }

                // Look for any customers.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer { CompanyName = "Acme", ContactName = "John Doe", EmployeeCount = 120},
                    new Customer { CompanyName = "Contoso", ContactName = "Jane Doe", EmployeeCount = 200 },
                    new Customer { CompanyName = "Fabrikam", ContactName = "John Smith", EmployeeCount = 50 },
                    new Customer { CompanyName = "AdventureWorks", ContactName = "Jane Smith", EmployeeCount = 500}
                    );
                context.SaveChanges();
            }
        }
    }
}
