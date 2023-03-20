using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        /*Write a program to print following series: 3,7,8,12,13,17,18,22,23*/
        public static void series()
        {
            int a = 3;
            Console.WriteLine(a);
            for(int i = 1; i <= 8; i++)
            {
                if(i%2 == 0)
                {
                    a++;
                    Console.WriteLine(a);
                }
                else
                {
                    a += 4;
                    Console.WriteLine(a);
                }
            }

        }
    }
}
