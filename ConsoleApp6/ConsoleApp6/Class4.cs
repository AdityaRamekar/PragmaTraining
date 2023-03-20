using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class fruit
    {
        public string name { get; set; }
        public string shape { get; set; }
        public string taste
        {
            get; set;
        }
        public string price
        {
            get; set;
        }
    }
        class Class4
        {
            public static void Main4()
            {
                fruit f = new fruit();

                Console.WriteLine("Enter Fruit name");
                f.name = Console.ReadLine();
                Console.WriteLine("Enter Fruit shape");
                f.shape = Console.ReadLine();
                Console.WriteLine("Enter Fruit taste");
                f.taste = Console.ReadLine();
                Console.WriteLine("Enter Fruit price");
                f.price = Console.ReadLine();


                Console.WriteLine("you got dicount of Rs " + (Convert.ToInt32(f.price) * 10 / 100) + " for " + f.name + " with better " + f.taste);
            }
        }
    
}
