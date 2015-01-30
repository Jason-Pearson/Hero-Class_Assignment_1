using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Loop
            //for (int i = 0; i < 100;i++ )
            //{
                Console.Write("What...is your name: ");
                string name = Console.ReadLine();

                Hero Destiny = new Hero(name);
                Destiny.fight();

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            //}
        }
    }
}
