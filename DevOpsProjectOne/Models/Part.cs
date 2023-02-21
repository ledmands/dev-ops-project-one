using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsProjectOne.Models
{
    [Table("Parts")]
    public class Part
    {
        [Key]
        public int Part_id { get; set; }
        public String Description { get; set; }
        public float Price { get; set; }
        public String Vendor_id { get; set; }
    }
}
