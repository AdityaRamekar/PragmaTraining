using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Education
    {
        public static void qualification(string tenth)
        {
            Console.WriteLine("SSC passed with " + tenth + " % ");
        }

        public static void qualification(string tenth, string twelve)
        {
            Console.WriteLine("SSC passed with " + tenth + " % ");
            Console.WriteLine("HSC passed with with " + twelve + " % ");

        }
        public static void qualification(string tenth, string twelve,string engg)
        {
            Console.WriteLine("SSC passed with " + tenth + " % ");
            Console.WriteLine("HSC passed with with " + twelve + " % ");
            Console.WriteLine("Engineering passed with " + engg + " % ");
        }
    }
    class Class4
    {
        public static void Main4()
        {

            Education.qualification("90","86","99");
        }
        
    }
}
