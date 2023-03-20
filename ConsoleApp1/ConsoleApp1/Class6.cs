using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class6
    {
        public static void reverse()
        {
            /*Write a program for displaying reverse of given nos 12,14,18,20,24,26,30*/
            int[] a = new int[] { 12, 14, 18, 20, 24, 26, 30 };
            Console.WriteLine("reverse of given nos are");
            for(int i = a.Count()-1;i>= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
