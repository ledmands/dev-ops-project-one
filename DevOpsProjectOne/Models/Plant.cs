using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsProjectOne.Models
{
    [Table("Plants")]
    public class Plant
    {
        [Key]
        public int Plant_id { get; set; }
        public String Address { get; set; }
        public String Name { get; set; }
    }
}

