using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileHandling
{

    public abstract class Trainee
    {
        public
        static string empId = "", name = "", address = "", dob = "", phone = "";
        public string marks = "";

        public Trainee() { }

        public void Input()
        {
            Console.WriteLine("Enter EmpId: ");
            empId = Console.ReadLine();
            Console.WriteLine("\nEnter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nEnter Address: ");
            address = Console.ReadLine();
            Console.WriteLine("\nEnter Dob: ");
            dob = Console.ReadLine();
            Console.WriteLine("\nEnter Phone: ");
            phone = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("EmpID = " + empId + "\n Name = " + name + "\n Address = " + address + "\n Dob = " + dob + "\n Phone = " + phone + "\n Marks = " + marks);
        }
        public virtual void Assessment()
        {
            Console.WriteLine("Parent Assessment");
        }


        public void FileRead()
        {
           
            FileStream F = new FileStream(@"C:\vsassessment\99", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            F.Close();
        }
        public void FileWrite()
        {
            Random rd = new Random();
            string filename = Convert.ToString(rd.Next(98, 124));
            FileStream F = new FileStream(@"C:\vsassessment\"+ filename , FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(F);
            sw.WriteLine("EmpId:" + empId);
            sw.WriteLine("Name:" + name);
            sw.WriteLine("Address:" + address);
            sw.WriteLine("Dob:" + dob);
            sw.WriteLine("Phone:" + phone);
            sw.WriteLine("Marks:" + marks);

            sw.Close();
            F.Close();
        }


    }

}
