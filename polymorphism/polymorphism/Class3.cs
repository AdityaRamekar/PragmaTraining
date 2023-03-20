using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class house
    {
        public void livingIn(string flat)
        {
            Console.WriteLine("You live peacefully in flat");
        }

        public void livingIn(string flat, string rowHouse)
        {
            Console.WriteLine("You are businessman");
            

        }
        public void livingIn(string flat, string rowHouse, string bunglow)
        {
            Console.WriteLine("You are Bloody Rich");
            
            
        }
    }
    class Class3
    {
          public static void Main3()
        {
            house h = new house();
            h.livingIn("flat\n\n");
            
        }
    }
}
