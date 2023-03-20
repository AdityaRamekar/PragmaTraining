using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Bottle
    {
        public string B
        {
            get; set;
        }
        public void randomBottle(string B)
        {
         
            Random rd = new Random();
            Console.WriteLine(" You got " + rd.Next(0,10) + " points for picking up " + B + " bottle ");
        }
    }
    class Class5
    {
        public static void Main5() {
            Bottle bottle = new Bottle();
            Console.WriteLine("Enter Waste bottle name");
            bottle.B = Console.ReadLine();
            bottle.randomBottle(bottle.B);
                }
    }
}
