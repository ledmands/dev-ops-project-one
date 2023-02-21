using DevOpsProjectOne.Models;
using System.Diagnostics;

namespace DevOpsProjectOne.Data
{
    public static class DBInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var user = new User[]
            {
                new User{First_Name = "Carson", Last_Name = "Alexander", Login_Name = "user1", Phone_Num = "1234567890", Plant_Location = "Georgia", Token = "123abc"},
                new User{First_Name = "Yan", Last_Name = "Li", Login_Name = "user2", Phone_Num = "1234567890", Plant_Location = "Georgia", Token = "123abc"},
                new User{First_Name = "Peggy", Last_Name = "Justice", Login_Name = "user3", Phone_Num = "1234567890", Plant_Location = "Georgia", Token = "123abc"},
                new User{First_Name = "Laura", Last_Name = "Norman", Login_Name = "user4", Phone_Num = "1234567890", Plant_Location = "Georgia", Token = "123abc"},
            };

            context.Users.AddRange(user);
            context.SaveChanges();

            var plant = new Plant[]
            {
                new Plant{Address="123 fake st",Name="plant 1"},
                new Plant{Address="123 fake st",Name="plant 2"},
                new Plant{Address="123 fake st",Name="plant 3"},
                new Plant{Address="123 fake st",Name="plant 3"},
            };

            context.Plant.AddRange(plant);
            context.SaveChanges();

            
        }

    }
}
