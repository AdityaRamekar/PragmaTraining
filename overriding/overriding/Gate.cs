using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    public abstract class Gate
    {
        public abstract void level();
        
         
    }

    public class Gate2019 : Gate
    {
        public override void level()
        {
            Console.WriteLine("Easy");
        }
    }

    class Gate2020 : Gate
    {
        public override void level()
        {
            Console.WriteLine("Moderate to Easy");
        }
    }
    class Gate2021 : Gate
    {
        public override void level()
        {
            Console.WriteLine("Moderate");
        }
    }
    class Gate2022 : Gate
    {
        public override void level()
        {
            Console.WriteLine("Moderate to Hard");
        }
    }

}
