using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class5
    {
        public static void OutPut()
        {
            /*What is the output of following statement*/
            int a=8;
            a++;
            ++a;
            int b = a++ + ++a + ++a + a++ + ++a + a + a;
            Console.WriteLine("unary operator prog:");
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
