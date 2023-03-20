using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Bag
    {
        public string price { get; set; }
        public string name { get; set; }
        public string capacity { get; set; }
    }
    class Class3
    {
        public static void Main3()
        {
            Bag bag = new Bag();
            Console.WriteLine("Enter bag name");
            bag.name = Console.ReadLine();

            Console.WriteLine("Enter bag capacity");
            bag.capacity = Console.ReadLine();

            Console.WriteLine("Enter bag price");
            bag.price = Console.ReadLine();

            Console.WriteLine("You ordered " + bag.name + " bag with capacity " + bag.capacity + " and price= " + bag.price);

        }
    }
}
