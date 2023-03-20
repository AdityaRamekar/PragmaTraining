using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Bulb
    {
        public string on { get; set; }
        public string off { get; set; }

        public void display(string s)
        {
            if (s.Equals("on"))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("bulb turned on");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if(s.Equals("off"))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("bulb is off");
            }
        }
    }
    class Class2
    {
        public static void Main2()
        {
            Bulb b = new Bulb();
            Console.WriteLine("\nturn bulb on\n");
            b.display(Console.ReadLine());
        }
    }
}
