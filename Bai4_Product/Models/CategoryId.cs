using System.ComponentModel.DataAnnotations;

namespace Bai4_Product.Models
{
    public class CategoryId
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        public string? CategoryName { get; set; }
        // Navigation property - thuoc tinh dieu huong 
        public List<Product>? Products { get; set; }
    }
}
