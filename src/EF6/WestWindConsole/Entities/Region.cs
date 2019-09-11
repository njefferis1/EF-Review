using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Regions")]
    public class Region
    {
        [Key]
        public int RegionID { get; set; }

        [Required, StringLength(50, ErrorMessage = "Region Description cannot be more than 50 characters long")]
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; } =
            new HashSet<Territory>();
    }
}
