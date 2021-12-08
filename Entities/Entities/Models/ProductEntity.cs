using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set;}

        //Category relationship
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
