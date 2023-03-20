using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    public abstract class Employee
    {
        public virtual void employee()
        {
            Console.WriteLine("parent ");
        }
    }

    public class Pragmasys : Employee
    {
        
        public override void employee()
        {
            Console.WriteLine("Aditya is Pragmasys Employee");
            
        }

    }
    /*
    public class Feb2023 : Employee
    {
        public override void employee()
        {
            Console.WriteLine("Aditya is feb2023 Employee");
         
        }
    }*/
}

