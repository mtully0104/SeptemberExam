using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberExam
{
    public class Bike
    {
        //prop
        public int ID { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }

        //constructors

        //methods
        public void AddVat(decimal vatRate)
        {
            price *= vatRate;
        }


    }
}
