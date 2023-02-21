using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsProjectOne.Models
{
    [Table("Plants_Parts")]
    public class Part_Plant
    {
        [Key]
        public int Plant_id { get; set; } // This will be the primary key. Entity automatically interprets ID as the primary key unless otherwise specified
        public String Part_id { get; set; }
        public int Quantity { get; set; }
    }
}
