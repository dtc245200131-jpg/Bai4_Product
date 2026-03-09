using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai4_Product.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ten khong duoc de trong")] 
        public string? ProductName { get; set; }
        [Range(0.01, 100000, ErrorMessage = "Price must be greater than 0.01")]
        public decimal Price { get; set; }
        [ForeignKey("Category")]// Khoa Ngoai lien ket den Category
        public int CategoryId { get; set; }
        // Navigation property - thuoc tinh dieu huong den Category
        public CategoryId? Category { get; set; }
    }
}
