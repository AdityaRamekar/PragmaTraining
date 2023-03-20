using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        public static void arraymax()
        {/*Write a program to accept an array of 3 rows and 3 columns and find the
greatest no and its position.*/
            int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] temp = new int[3] { a[0, 0],0,0 };
            for(int i = 0;i<=2;i++)
            {
                for(int j = 0;j<=2;j++)
                {
                    if (temp[0] < a[i,j])
                    {
                        temp[0] = a[i , j];
                        temp[1] = i;
                        temp[2] = j;
                    }
                }
            }
            Console.WriteLine("max = " + temp[0] + " ,location = (" + temp[1]+ " ," + temp[2] + ")");
        }
    }
}
