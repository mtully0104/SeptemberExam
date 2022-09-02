using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeptemberExam;

namespace DataManagement1
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeData db = new BikeData();

            using (db)
            {
                Bike b1 = new Bike()
                {
                    ID = 10,
                    Name = "Hot Wheels",
                    Type = Bike.BikeTypes.Electric,
                    Price = 129.99m,
                    Description = "Wheels ipsum dolor sit amet, consectetur adipiscing elit. Nunc egestas laoreet lobortis. Quisque malesuada ullamcorper sem nec efficitur. Vivamus placerat"
                };
                Bike b2 = new Bike()
                {
                    ID = 20,
                    Name = "Cold Wheels",
                    Type = Bike.BikeTypes.Regular,

                    Price = 159.99m,
                    Description = "Cold ipsum dolor sit amet, consectetur adipiscing elit. Nunc egestas laoreet lobortis. Quisque malesuada ullamcorper sem nec efficitur. Vivamus placerat"
                };
                Bike b3 = new Bike()
                {
                    ID = 30,
                    Name = "Black Wheels",
                    Type = Bike.BikeTypes.Electric,

                    Price = 139.99m,
                    Description = "Black ipsum dolor sit amet, consectetur adipiscing elit. Nunc egestas laoreet lobortis. Quisque malesuada ullamcorper sem nec efficitur. Vivamus placerat"
                };
                Bike b4 = new Bike()
                {
                    ID = 40,
                    Name = "Blue Wheels",
                    Type = Bike.BikeTypes.Racing,

                    Price = 179.99m,
                    Description = "Blue ipsum dolor sit amet, consectetur adipiscing elit. Nunc egestas laoreet lobortis. Quisque malesuada ullamcorper sem nec efficitur. Vivamus placerat"
                };
                Bike b5 = new Bike()
                {
                    ID = 50,
                    Name = "Red Wheels",
                    Type = Bike.BikeTypes.Regular,

                    Price = 139.99m,
                    Description = "Red ipsum dolor sit amet, consectetur adipiscing elit. Nunc egestas laoreet lobortis. Quisque malesuada ullamcorper sem nec efficitur. Vivamus placerat"
                };
                Bike b6 = new Bike()
                {
                    ID = 60,
                    Name = "Green Wheels",
                    Type = Bike.BikeTypes.Racing,

                    Price = 139.99m,
                    Description = "Green ipsum dolor sit amet, consectetur adipiscing elit. Nunc egestas laoreet lobortis. Quisque malesuada ullamcorper sem nec efficitur. Vivamus placerat"
                };

                Console.WriteLine("Bike have been created");
                db.Bikes.Add(b1);
                db.Bikes.Add(b2);
                db.Bikes.Add(b3);
                db.Bikes.Add(b4);
                db.Bikes.Add(b5);
                db.Bikes.Add(b6);

                db.SaveChanges();
                Console.WriteLine("Data has been saved to DB, hit enter to continue");
                Console.ReadLine();

            }
        }
    } 
}
    

