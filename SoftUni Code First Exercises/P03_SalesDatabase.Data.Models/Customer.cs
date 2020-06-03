using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [StringLength(80)]
        public string Email { get; set; }
        
        [Required]
        public string CreditCardNumber { get; set; }
        public ICollection<Sale> Sales { get; set; }

        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }
    }
}
