using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [DefaultValue("No description")]
        public string Description { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public ICollection<Sale> Sales { get; set; }

        public Product()
        {
            this.Sales = new HashSet<Sale>();
        }
    }
}
