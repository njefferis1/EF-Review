using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    // TODO: Begin reviewing entity attributes
    // Identifies which database table this entity is supposed to represent (be mapped to).
    [Table("Categories", Schema = "dbo")] // <- called an attribute. used to map code to database. 'schema' is optional
    public class Category
    {
        [Key] // Indicates that this property maps to the prmary key in the database
        public int CategoryID { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(15, ErrorMessage = "Category Name cannot be more than 15 characters long")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

        [StringLength(40, ErrorMessage = "Picture Mime Type has a maximum of 40 characters")]
        public string PictureMimeType { get; set; }

        // TODO: Introducing Navigation Properties
        public virtual ICollection<Product> Products { get; set; } =
            new HashSet<Product>();
    }
}
