using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
    class DefaultConstructor
    {//default constructor is a special method which is called automatically when new instance is created
        int i = 0;

        public static void Main1()
        {
            DefaultConstructor d = new DefaultConstructor();
            Console.WriteLine("default constructor = " + d.i);
        }
    }
}
