using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int SalesRepID { get; set; }

        [Required, ForeignKey("Customer"), StringLength(5, ErrorMessage = "Customer ID cannot be more than 5 characters long")]
        public string CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime PaymentDueDate { get; set; }
        
        public decimal Freight { get; set; }

        public bool Shipped { get; set; }

        [StringLength(40, ErrorMessage = "Ship Name cannot be more than 40 characters long")]
        public string ShipName { get; set; }

        public int? ShipAddressID { get; set; }

        [StringLength(250, ErrorMessage = "Comment Section cannot be more than 250 characters long")]
        public string Comments { get; set; }

        public virtual ICollection<Payment> Payments { get; set; } =
            new HashSet<Payment>();

        public virtual ICollection<Shipment> Shipments { get; set; } =
            new HashSet<Shipment>();

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } =
            new HashSet<OrderDetail>();
    }
}
