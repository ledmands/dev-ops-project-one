using System.ComponentModel.DataAnnotations;

namespace DevOpsProjectOne.Models
{
    public class Vendor
    {
        [Key]
        public int Vendor_id { get; set; } // This will be the primary key. Entity automatically interprets ID as the primary key unless otherwise specified
        public String Name { get; set; }
        public String Location { get; set; }
       
    }
}
