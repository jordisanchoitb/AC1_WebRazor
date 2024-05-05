using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;

namespace Ac1WebRazor.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        public string ContactName { get; set; } = string.Empty;
        [Required]
        [Range(1, int.MaxValue)]
        public int EmployeeCount { get; set; }
    }
}