using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Pragmasys();//parent
            Pragmasys p = new Pragmasys();//child

            //e=p;

            //Employee p1 = new Feb2023();
            Gate g19 = new Gate2019();
            Gate g20 = new Gate2020();
            Gate2021 g21 = new Gate2021();
            Gate2022 g22 = new Gate2022();

           // p.employee();
            e.employee();//calling child method using parent object
           // p1.employee();//calling child method using child object



            //Gate gate = new Gate();
            
            //gate.level();
            g19.level();
            g20.level();
            g21.level();
            g22.level();
            Console.ReadKey();

           
        }
    }
}
