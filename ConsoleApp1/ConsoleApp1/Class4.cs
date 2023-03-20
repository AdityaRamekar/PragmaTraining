using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        public static void DivBySeven()
        {/*Write a program to display all the numbers divisible by 7 upto 100.*/
            int i = 1;
            while(i != 100)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
