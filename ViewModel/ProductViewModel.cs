using E_Commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public IFormFile? Image { get; set; }
        public string Img { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
       
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
