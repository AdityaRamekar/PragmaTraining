using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class2
    { //Create an array which has 1-n elements in 1-n row and find row wise sum;
        public static void jaggedArray()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            //insert
            for(int i = 0;i< n; i++)
            {
                a[i] = new int[i + 1];//create new row of array each time
                for(int j = 0; j <= i; j++)
                {
                    a[i][j] = j;
                }
            }
            //display
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine("a["+i+"]"+"["+j+"]" + a[i][j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                foreach (int k in a[i])
                {
                    sum += k;
                }
                Console.WriteLine("sum =" + sum);
            }
            Console.WriteLine();
        }
    }
}
