namespace DevOpsProjectOne.Models
{
    public class User
    {
        public int ID { get; set; } // This will be the primary key. Entity automatically interprets ID as the primary key unless otherwise specified
        public String Username { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        // Other Properties that exist in the table go here
        //public String LastName { get; set; }
        //public String LastName { get; set; }
        //public String LastName { get; set; }
    }
}
