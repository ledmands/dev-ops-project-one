using System.ComponentModel.DataAnnotations;
namespace DevOpsProjectOne.Models
{
    public class Part
    {
        [Key]
        public int Part_id { get; set; }
        public String Description { get; set; }
        public float Price { get; set; }
        public String Vendor { get; set; }
    }
}
