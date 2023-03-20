using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class bike
    {
        public void bikeInfo(string info1)
        {
            Console.WriteLine("Buy Scooty");
        }

        public void bikeInfo(string info1, string info2)
        {
            Console.WriteLine("buy a normal bike");


        }
        public void bikeInfo(string info1, string info2, string info3)
        {
            Console.WriteLine("buy Sports bike");


        }
    }
    class Class1
    {
        public static void Main1()
        {
            bike b = new bike();
            b.bikeInfo("electrical");
        }
    }
}
