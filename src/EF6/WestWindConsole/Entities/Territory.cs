using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key, StringLength(20, ErrorMessage = "Territory ID cannot be more than 20 characters long")]
        public string TerritoryID { get; set; }

        [Required, StringLength(50, ErrorMessage = "Territory Description cannot be more that 50 characters long")]
        public string TerritoryDescription { get; set; }

        [ForeignKey("Region")]
        public int RegionID { get; set; }

        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; } =
            new HashSet<EmployeeTerritory>();
    }
}
