using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment17_2_2023
{
 
    class Program
    {
        static void Main(string[] args)
        {
            int c = 65;


            for (int i = 0; i < 5; i++)
            {
               for (int j = 0; j < 5; j++)
                {
                    if (j - i <= 0)
                    {
                        Console.Write((char)c + "");

                        c++;
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
