using System.ComponentModel.DataAnnotations;

namespace ShopEase.Web.Models
{ 
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
