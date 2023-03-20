using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class food
    {
        public void Eat(string food1)
        {
            Console.WriteLine("you eat light food");
        }

        public void Eat(string food1, string food2)
        {
            Console.WriteLine("you eat appropriate food");


        }
        public void Eat(string food1, string food2, string food3)
        {
            Console.WriteLine("you eat food like prince");


        }
    }
    class Class2
    {
        public static void main2()
        {
            food f = new food();
            f.Eat("Bhakar","Bhaji","Rice");

        }
    }
}
