using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class1
    {
        public static void Main1()
        {
            int[,] a ={ {1,2,3},
                                        {4,5,6},
                                        {7,8,9} };
            int[,] b = { {1,2,3},
                                        {4,5,6},
                                        {7,8,9} };
            int[,] c = new int[3, 3];

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    for(int k = 0;k <=2; k++)
                    {
                        c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
                    
                }
            }
            Console.WriteLine("\n Sum of two matrices:\n");
            for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.Write(+ c[i,j] + " " );
                    }
                    Console.WriteLine();
                }
            }
        }
    }


