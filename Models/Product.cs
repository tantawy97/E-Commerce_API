using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public byte[] Photo { get; set; }
        [Required, MaxLength(50)]
        public double Price { get; set; }
        [Required, MaxLength(50)]
        public double Quantity { get; set; }
        [ForeignKey("Category")]
        public int Categoryid { get; set; }
        public Category Category { get; set; }

        
    }
}
