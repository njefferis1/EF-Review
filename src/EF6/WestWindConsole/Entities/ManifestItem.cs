using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("ManifestItems")]
    public class ManifestItem
    {
        [Key]
        public int ManifestItemID { get; set; }

        [ForeignKey("Shipment")]
        public int ShipmentID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public int ShipQuantity { get; set; }
    }
}
