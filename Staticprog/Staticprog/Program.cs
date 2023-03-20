using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticprog
{
    class Program
    {
        static int employeeSalary = 450000;
        static int Salary = employeeSalary / 15;
        static void Main(string[] args)
        {
            Program p = new Program();
            
            p.AdityaSal();
            p.BalasahebSal();
            p.TejasSal();
            p.Saurabh();
            p.RemainingSal();
            Console.ReadKey();
        }
        void AdityaSal()
        {
            Console.WriteLine(" Adi Sal is " + Salary);
            employeeSalary -= (employeeSalary / 15);
        }

        void TejasSal()
        {
            Console.WriteLine(" Tejas Sal is " + Salary);
            employeeSalary -= (employeeSalary / 15);
        }
        void BalasahebSal()
        {
            Console.WriteLine(" Balasaheb Sal is " + Salary);
            employeeSalary -= (employeeSalary / 15);
        }
        void Saurabh()
        {
            Console.WriteLine(" Balasaheb Sal is " + Salary);
            employeeSalary -= (employeeSalary / 15);
        }
        void RemainingSal()
        {
            Console.WriteLine("Remaining Sal is " + employeeSalary);
        }

    }
}
