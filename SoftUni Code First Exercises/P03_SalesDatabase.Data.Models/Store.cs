using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Stores")]
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(80)")]
        public string Name { get; set; }
        public ICollection<Sale> Sales { get; set; }

        public Store()
        {
            this.Sales = new HashSet<Sale>();
        }
    }
}
