using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public  class Invoice
    {
        //attribute
        //properties
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string ShipTo { get; set; }
        public string ProductName { get; set; }
        public string Total { get; set; }

    }

  
    class Program
    {
        static void Main(string[] args)
        {
            Class5.Main5();
            Class4.Main4();
            Class3.Main3();
            Class2.Main2();
            Class1.Main1();
            
            Invoice invoice = new Invoice();

            Console.WriteLine("Enter Company Name");
            invoice.BusinessName = Console.ReadLine();
         
            Console.WriteLine("Enter Email");
            invoice.Email = Console.ReadLine();
           

            Console.WriteLine("Enter Shipping address");
            invoice.ShipTo = Console.ReadLine();
           


            Console.WriteLine("Enter Product Name");
            invoice.ProductName = Console.ReadLine();
           

            Console.WriteLine("Enter Total");
            invoice.Total = Console.ReadLine();

            Console.WriteLine("\n-------Your Invoice----------");
            Console.WriteLine(invoice.BusinessName);
            Console.WriteLine(invoice.Email);
            Console.WriteLine(invoice.ShipTo);
            Console.WriteLine(invoice.ProductName);
            Console.WriteLine(invoice.Total);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));



        }
    }
}
