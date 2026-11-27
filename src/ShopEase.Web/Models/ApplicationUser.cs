using Microsoft.AspNetCore.Identity;

namespace ShopEase.Web.Models
{
    public class ApplicationUser
    {
        public string FullName { get; set; } = string.Empty;

        public string? Address { get; set; }

        public string? City { get; set; }
    }
}
