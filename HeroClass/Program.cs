using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Jason Pearson - 300810977
 * Program: Assignment One - Hero Class
 * Date last modified: Feb 6/15
 * Revision History: Final Product - Jan 30/15
 * Revision History: Second Final Product - Introducing the SuperHero Sub-Class
 */
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
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                
                //Implement the Hero base-class
                Hero Destiny = new Hero(name);//New Hero object that takes the name from the base-class constructor
                Destiny.show(); //display stats - show Method
                Destiny.fight();//initiate combat - Fight, hitAttempt, and hitDamage Methods
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                
                //Implement the SuperHero sub-class
                SuperHero Fate = new SuperHero(name);
                Fate.showPowers();
                Fate.fight();//call the fight method inherited from the base class
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                Console.WriteLine("");
                Console.Write("Press any key to exit");
                Console.ReadKey();
            //}
        }
    }
}
