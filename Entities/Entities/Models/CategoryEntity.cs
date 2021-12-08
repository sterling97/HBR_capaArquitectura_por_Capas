using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public int CategoryId { get; set; }

        [Required]
        [StringLength (100)]
        public string CategoryName { get; set; }

        //Product relationship
        public ICollection<ProductEntity> Products { get; set; }
    }
}
