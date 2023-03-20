using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void display1()
        {
            //for (int i = 1; i <= 10; i++)
            Console.WriteLine("hi");
            Thread.Sleep(2000);
        }
        static void display2()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("hello");

                Thread.Sleep(2000);
            }
        }
        static void display3()
        {
            for (int i = 1; i <= 3; i++)
                Console.WriteLine("Welcome");
            
            Thread.Sleep(1000);
        }
        static void Main(string[] args)
        {


            
                Thread t1 = new Thread(display1);
            Thread t2 = new Thread(display2);
            Thread t3 = new Thread(display3);

            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
            Thread.Sleep(1000);
            Console.WriteLine("Thread Ends");

            //Console.WriteLine("Main");

            Console.ReadKey();
        }
    }
}
