using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Addresses")]
    public class Addresses
    {
        [Key]
        public int AddressID { get; set; }

        [Required, StringLength(60, ErrorMessage = "Address cannot be more than 60 characters long")]
        public string Address { get; set; }

        [Required, StringLength(15, ErrorMessage = "City cannot be more than 15 characters long")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "Region Name cannot be more than 15 characters long")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "Postal Code cannot be more than 10 characters long")]
        public string PostalCode { get; set; }

        [Required, StringLength(15, ErrorMessage = "Country cannot be more than 15 characters long")]
        public string Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; } =
            new HashSet<Order>();

        public virtual ICollection<Employee> Employees { get; set; } =
            new HashSet<Employee>();

        public virtual ICollection<Customer> Customers { get; set; } =
            new HashSet<Customer>();

        public virtual ICollection<Supplier> Suppliers { get; set; } =
            new HashSet<Supplier>();
    }
}
