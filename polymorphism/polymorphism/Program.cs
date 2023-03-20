using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class shape
    {
        public void Shape(string L,string b,string h)
        {
            Console.WriteLine("Area of Triangle =" + (0.5 *( Convert.ToInt32(L)* (Convert.ToInt32(b)* (Convert.ToInt32(h))))));
        }
        public void Shape(string radius)
        {
            Console.WriteLine("Area of Circle =" + (Convert.ToInt32(radius) * Convert.ToInt32(radius)));
        }
        public void Shape(string L,string b)
        {
            Console.WriteLine("Area of Rectangle =" + (0.5 * (Convert.ToInt32(L) * (Convert.ToInt32(b)))));
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            shape s = new shape();
            s.Shape("5");
            Class1.Main1();
            Class2.main2();
            Class3.Main3();
            Class4.Main4();
        }
    }
}
