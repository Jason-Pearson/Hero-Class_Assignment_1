using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Jason Pearson - 300810977
 * Program: Assignment One - Hero Class
 * Date last modified: Jan 30/15
 * Revision History: Final Product*/
namespace HeroClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Optional Test Loop
            //for (int i = 0; i < 100;i++ )
            //{
                Console.Write("What...is your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("");
                
                Hero Destiny = new Hero(name);//takes the name from user input as the name
                Destiny.show(); //display stats - show Method
                Destiny.fight();//initiate combat - Fight, hitAttempt, and hitDamage Methods

                Console.WriteLine("");
                Console.Write("Press any key to exit");
                Console.ReadKey();
            //}
        }
    }
}
