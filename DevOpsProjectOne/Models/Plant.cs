using System.ComponentModel.DataAnnotations;
namespace DevOpsProjectOne.Models
{
    public class Plant
    {
        [Key]
        public int Plant_id { get; set; }
        public String Address { get; set; }
        public String Name { get; set; }
    }
}

