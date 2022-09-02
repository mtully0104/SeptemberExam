using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberExam
{
    public class Bike
    {
        //prop
        public int BikeID { get; set; }
        public int ID { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //constructors

        //methods
        public void AddVat(decimal vatRate)
        {
            Price *= vatRate;
        }


    }//endofbikeclass


    public class BikeData:DbContext
    {
        public BikeData() : base("MyBikeData2022") { }

        public DbSet<Bike> Bikes { get; set; }
    }

    
}
