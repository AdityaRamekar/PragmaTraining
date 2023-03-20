using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        // WAP to find the row wise sum and column wise sum of 3x3 array
        public static void rowColSum()
        {
            int[,] a = new int[3,3]{ { 1,2,3},
                        {4,5,6},
                        {7,8,9 }};

            
            for(int i = 0; i< 3; i++)
            {
                int sumofrow = 0;
                for (int j = 0; j < 3; j++)
                {
                    sumofrow += a[i, j];
                }
                Console.WriteLine("sum of row: "+ (i + 1) + " is " + sumofrow);
            }

            
            for (int j = 0; j < 3; j++)
            {
                int sumofcol = 0;
                for (int i = 0; i < 3; i++)
                {
                    sumofcol += a[i, j];
                }
                Console.WriteLine("sum of column " + (j + 1) + " is " + sumofcol);
            }
        }
    }
}
