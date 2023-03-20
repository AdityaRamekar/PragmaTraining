using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class bell
    {
        public string ringBell { get; set; }

      
    }
    class Class1
    {
        public static void Main1()
        {
            bell Bell = new bell();
            Bell.ringBell = Console.ReadLine();
            Console.WriteLine("ring the bell");
                if (Bell.ringBell.Equals("push"))
                Console.WriteLine(">>>>ting....tong<<<<<");
            Console.Beep();
            Console.Beep();
        }
    }
}
