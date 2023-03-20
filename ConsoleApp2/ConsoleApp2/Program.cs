using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            
            bool cont = true;
            Console.WriteLine("Enter 1st no.");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd no.");
            b = Convert.ToInt32(Console.ReadLine());
            while (cont)
            {
               
                Console.WriteLine("Enter any of the +,-,*,/ operations,type 'no' to exit");
              
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine(a + "+" + b + "=" + (a + b));
                        break;
                    case "-":
                        Console.WriteLine(a + "-" + b + "=" + (a - b));
                        break;
                    case "*":
                        Console.WriteLine(a + "*" + b + "=" + (a * b));
                        break;
                    case "/":
                        Console.WriteLine(a + "/" + b + "=" + (a / b));
                        break;
                    case "no":
                        cont = false;
                        Console.WriteLine("exiting..");
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
             

            }
        }
    }
}
