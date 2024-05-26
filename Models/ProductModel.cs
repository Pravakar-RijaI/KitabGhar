using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitabGhar.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [ActivatorUtilitiesConstructor]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(1,1000)]
        public double Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoryModel Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
