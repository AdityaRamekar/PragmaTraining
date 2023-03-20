using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        public static void great()
        {/*Write a program to reverse a given no.*/
            int a = 123,b = 0;
            
            while(a != 0)
            {
                b = b + a % 10;
                b *= 10;

                a /= 10;
            }
            Console.WriteLine("reverse = " + b/10);
        }
    }
}
