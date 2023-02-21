using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsProjectOne.Models
{
    [Table("Vendor")]
    public class Vendor
    {
        [Key]
        public int Vendor_id { get; set; } // This will be the primary key. Entity automatically interprets ID as the primary key unless otherwise specified
        public String Vendor_Name { get; set; }
        public String Location { get; set; }
       
    }
}
