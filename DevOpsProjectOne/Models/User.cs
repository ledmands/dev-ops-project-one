using System.ComponentModel.DataAnnotations;

namespace DevOpsProjectOne.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; } // This will be the primary key. Entity automatically interprets ID as the primary key unless otherwise specified
        public String First_Name { get; set; }
        public String Last_Name { get; set; }
        public String Login { get; set; }
        public String Phone_Num { get; set; }
        public String Plant_Location { get; set; }
        public String Token { get; set; }
    }
}
