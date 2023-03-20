using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class Loan
    {
        public void loan()
        {
            Console.WriteLine("Loan Rate of Interest");
        }
    }

    class HDFC
    {
        public void loan()
        {
            Console.WriteLine("Loan Rate of Interest is 10.5%");
        }
    }
    class IDBI
    {
        public void loan()
        {
            Console.WriteLine("Loan Rate of Interest is 9.5%");
        }
    }
    class ICICI
    {
        public void loan()
        {
            Console.WriteLine("Loan Rate of Interest is 10.75%");
        }
    }
}
