using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0,100, ErrorMessage = "The Field Display Order must be between 0-100")]
        public int DisplayOrder { get; set; } 
    }
}
