using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void LSearch(int[] arr,int le)
        {
            int loc = 0;
            bool flag = false;
            foreach(int i in arr)
            {
                if(i == le)
                {
                    Console.Write("Element found at location " + loc +"\n");
                    flag = true;
                    break;
                }
                else
                {
                    loc++;
                }
            }
            if (flag == false)
            {
                Console.Write("Element not found");
            }
           
          
           
        }
        static void binSearch(int[] arr, int le)
        {
            bool flag = true;
            int beg = 0, end = arr.Length;
            int mid = arr.Length / 2;
            while (true)
            {
                if (le == arr[mid])
                {
                    Console.Write("Element found at loc " + mid + "\n");
                    flag = false;
                    break;
                }
                else if (le > arr[mid])
                {
                    beg = mid + 1;
                    mid = (beg + end) / 2;
                }
                else
                {
                    end = mid - 1;
                    mid = (beg + end) / 2;
                }

                if ((mid == 0 )&&( flag == false))
                {
                    Console.Write("Element not found");
                    break;
                }
            }
        }

        static void selSort(int[] a)
        {
            int temp;
          
            for(int i = 0; i< a.Length; i++)
            {
                temp = a[i];
                int j = i + 1;
               
                while(j < a.Length)
                    if( a[i] > a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;

                        j++;
                    }
                
            }
        }
        static void BubbleSort(int[] a)
        {
            int a1, a2,temp;
            for(int i = 0;i< a.Length - 1; i++)
            {
                for(int j = 0;j < a.Length-i-1; j++)
                {
                    a1 = a[j];
                    a2 = a[j + 1];
                    if (a[j] > a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }
            }
        }

        static void Delete(int[] a, int element, int position)
        {
            
            for (int i = position; i < a.Length; i++)
            {
                a[position] = a[position + 1];
               }
        }

        static void insert(int[] a, int element, int position)
        {
          //  int[] b = new int[11];            
            int lterm = a.Length - 1;
           for (int i = position; i < a.Length; i++)
            {
                a[lterm] = a[lterm-1];
                lterm--;
            }
          /* for(int i = 0;i< b.Length - 1; i++)
            {
                if (i == position - 1)
                {
                    b[i] = element;
                    b[i+1] = a[i];
                }
                else
                {
                    b[i] = a[i];
                }
            }
            a = b;*/
        }
        
        static void Main(string[] args)
        {

            /*Create an array of 10 nos and input elements from user and
            1.Accept another no in a variable and search its location in above array using :-
              A Lenear Search
              B.Binary Search
            2.Sort the array using:-
              A   Selection sort
              B Bubble Sort
            3.Delete a no from specified position
            4.Insert an element at specified position in array.*/

            int[] a = new int[10] {10,9,8,7,6,5,4,3,2,1 };
            int le = 1;
            Console.WriteLine("Searching location");
            LSearch(a,le);
            Console.WriteLine("Selection Sort");
            selSort(a);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            a = new int[10]{ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("\nBubble Sort");
            BubbleSort(a);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nBinary search");
            binSearch(a,le);

            a = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            insert(a, 12, 1);

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            /*
            int[] b = new int[11];
            insert(b,11,9);

            Console.WriteLine("\nAfter Insertion");
            foreach (int i in b)
            {
                Console.Write(i + " ");
            }

            Delete(b, 11, 9);

            Console.WriteLine("\nAfter Deletion");
            foreach (int i in b)
            {
                Console.Write(i + " ");
            }

            */
            Class1.Main1();
        }
    }
}
