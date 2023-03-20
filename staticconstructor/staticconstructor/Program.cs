using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
    class Program
    {
        public static int bal = 0;
        static DateTime time;
        static String str;
        static void Main(string[] args)
        {
            DefaultConstructor.Main1();
            Child p = new Child();
            Child p1 = new Child();
            Console.WriteLine(bal);
            Console.WriteLine(bal);
            Console.WriteLine(bal);
            Console.WriteLine(bal);

            Console.WriteLine(time.ToString());
            
            Console.WriteLine(str == null?"str == null":str);
        }
      
    }
    class Child : Program
    {//static constructor is called only once,its initialized value is available to everyone
        static Child()
        {
            bal += 2;
        }
        public Child()
        {
            bal += 2;
        }
    }
}
