using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [ForeignKey("PaymentType")]
        public int PaymentTypeID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [Required]
        public Guid TransactionID { get; set; }

        public DateTime ClearedDate { get; set; }
    }
}
