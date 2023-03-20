using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class7
    {
        public static void prime()
        {

            /*Write a program to create collection of prime no's upto 50 using LINQ.*/
            int[] a = new int[15];
            int j = 0;
            
            for (int i = 2; i != 50; i++)
            {
                int count = 0;
                for (int k = 2;k < i; k++)
                {
                    if((i % k == 0))
                    {
                        count++;
                    }
                   }
                if(count == 0)
                {
                    a[j] = i;
                    j++;
                }
            }
            Console.WriteLine("prime nos: ");
            for(int i = 0;i< a.Count();i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
