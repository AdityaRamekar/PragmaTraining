using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public abstract class Employee
    {
        protected
        string EmpID, Ename;
        protected    
        int Salary;
        public
        abstract string  Sal();
       
    }
    public class RegEmp : Employee
    {
        float Pf = 17.3f, Allowance = 83.2f;

        public RegEmp(string EmpID,string Ename,int Salary)
        {
            base.EmpID = EmpID;
            base.Ename = Ename;
            base.Salary = Salary;

        }
        public override string Sal()
        {
            return base.Ename+"'s regular salary is " + (Salary+(Salary*Allowance)/100-(Salary*Pf)/100);
        }
    }
    public class DailyWagEmp : Employee
    {
        int PDays;
        public DailyWagEmp(string EmpID, string Ename,int PDays)
        {
            base.EmpID = EmpID;
            base.Ename = Ename;
            this.PDays = PDays;
        }
        public override string Sal()
        {
            return base.Ename + "'s daily wage salary is " + PDays * 800;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {/*
            Write a program to create a class Employee with fields EmpID, Ename, Salary and function calculate salary ,
            create 2 child classes Regular Employee and Daily Wage Employee.Override calculate salary in both classes. 
            Deduct PF and add allownces for Regular Employee and No of present days*800 for Daily wage employee.
            Create objects of both classes and display salary.*/
            DailyWagEmp Aditya1 = new DailyWagEmp("1035","Aditya",7);

            RegEmp Aditya = new RegEmp("1033", "Aditya", 15000);
            Console.WriteLine(Aditya.Sal());

            Console.WriteLine(Aditya1.Sal());

        }
    }
}
