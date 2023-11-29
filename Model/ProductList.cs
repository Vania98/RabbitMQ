using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Store_1.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsumerRab.Model
{
    public class ProductList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(100)]
        public string ClientName { get; set; }

    }
}
