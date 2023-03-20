using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static bool Search(int[] a,int ele)
        {
            foreach(int i in a)
            {
                if(i == ele)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] insertArray(int[] arr,params int[] a)
        {
            
            for(int i = 0;i< a.Length; i++)
            {
                arr[i] = a[i];
            }

            return arr;

        }

        static void display(int[] a)
        {
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            // WAP to enter any no of elements from user and one no to search from that array, return true or false.

           // Class2.jaggedArray();
//Class1.rowColSum();

            int[] a = new int[5];
            //int element = 5;//element to search
            int element,i=0;
            while (true)
            {
                element = Convert.ToInt32(Console.ReadLine());
                insertArray(a,element);
                if(element == -1)
                {
                    break;
                }
                i++;
            }

            display(a);
            
            if (Search(a, 5))
            {
                Console.WriteLine("found");
            }


            // WAP to find the row wise sum and column wise sum of 3x3 array
            //Create an array which has 1-n elements in 1-n row and find row wise sum;
        }
    }
}
