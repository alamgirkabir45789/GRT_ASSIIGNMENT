using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT_ASSIIGNMENT.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProductCategoryName { get; set; }
      
        public ICollection<Product> Products { get; set; }
    }
}
