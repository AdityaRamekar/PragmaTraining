using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("even nos upto 100: ");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }

            //display - 1,2,4,7,11,16,22--100
            Console.WriteLine("\nQ2)");
            int cnt = 1;
            for (int i = 1; cnt <= 100; i++)
            {
                Console.Write((cnt) + " ");
                cnt += i;
            }

            //display - 1,2,4,5,7,8,10,11---100
            Console.WriteLine("\nQ3)");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            //display-0,1,1,2,3,5,8,13,21 factorial
            Console.WriteLine("\nQ4)");
            int fib0 = 0, fib1 = 1, temp = 1;
            Console.Write(fib0 + " ");
            Console.Write(fib1 + " ");
            for (; temp <= 21;)
            {
                Console.Write(temp + " ");
                fib0 = fib1;
                fib1 = temp;
                temp = fib0 + fib1;

            }

            // Accept a no's from the user and check , its prime or non prime
            Console.WriteLine("\nQ5)");
            Console.WriteLine("Enter a number to check prime or not");

            int p = Convert.ToInt32(Console.ReadLine());
            int noofdividedCont = 0;
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0)
                {
                    noofdividedCont++;
                }
            }
            if (noofdividedCont == 0)
                Console.Write("prime");
            else
                Console.Write("not prime");


            // Accept a no and check , its palindrome or non palindrome.
            Console.WriteLine("\nQ6)");
            Console.WriteLine("Accept a no and check , its palindrome or non palindrome");

            string pal = Console.ReadLine();
            char[] palin = pal.ToCharArray();
            char[] palin2 = palin;
            Array.Reverse(palin2);
            if (Enumerable.SequenceEqual(palin, palin2))
            {
                Console.WriteLine("Palindrome!!");
            }




            // Display all prime no and palindrom no's upto 100
            int[] a = new int[25];
            int j = 0;

            for (int i = 2; i != 100; i++)
            {
                int count = 0;
                for (int k = 2; k < i; k++)
                {
                    if ((i % k == 0))
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    a[j] = i;
                    j++;
                }
            }
            Console.WriteLine("prime nos: ");
            for (int i = 0; i < a.Count(); i++)
            {
                Console.WriteLine(a[i]);
            }

            //ALL PALINDROME

            for (int num = 1; num <= 100; num++)
            {
                int tem = num;
                int rev = 0;
                while (tem > 0)
                {
                    rev = rev * 10 + tem % 10;
                    tem /= 10;
                }
                if (rev == num)
                    Console.Write(num + " ");
            }
        }
    }
}
