using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key, StringLength(5, ErrorMessage = "Customer ID cannot be more than 5 characters long")]
        public string CustomerID { get; set; }

        [Required, StringLength(40, ErrorMessage = "Company Name cannot be more than 40 characters long")]
        public string CompanyName { get; set; }

        [Required, StringLength(30, ErrorMessage = "Contact Name cannot be more than 30 characters long")]
        public string ContactName { get; set; }

        [StringLength(30, ErrorMessage = "Contact Title cannot be more than 30 characters long")]
        public string ContactTitle { get; set; }

        [Required, StringLength(50, ErrorMessage = "Contact Email cannot be more than 50 characters long")]
        public string ContactEmail { get; set; }

        [Required, StringLength(60, ErrorMessage = "Address ID cannot be more than 60 characters long")]
        public string AddressId { get; set; }

        [Required, StringLength(24, ErrorMessage = "Phone Number cannot be more than 24 characters long")]
        public string Phone { get; set; }

        [StringLength(24, ErrorMessage = "Fax info cannot be more than 24 characters long")]
        public string Fax { get; set; }

        public virtual ICollection<Order> Orders { get; set; } =
            new HashSet<Order>();
    }
}
