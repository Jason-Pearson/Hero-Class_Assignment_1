using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Jason Pearson - 300810977
 * Program Description: Assignment Two - Build and implement the SuperHero Sub-Class, which picks three superpowers randomely and displays them through its own new class object. 
 * Date last modified: Feb 6/15
 * Revision History: Final Product - Jan 30/15
 * Revision History: Second Final Product - Introducing the SuperHero Sub-Class
 */
namespace HeroClass
{
    class SuperHero : Hero // sub-class inherits the base class (Hero)
    {
        //Private Property
        private string[] superPowers = new string [3];
        
        //Sub-Class Constructor
        public SuperHero(string name) : base (name)
        {
            this.generateRandomPowers();
        }
        //Generate three Superpowers from the six, then assign them to the superPowers array
        private void generateRandomPowers()
        {
            string[] superPowersList = new string [6] { "Super Speed", "Super Strength", "Body Armour", "Flight",
            "Fire Generation", "Weather Control"};
            
            int[] power = new int[3]; //Int Array - To hold the three numbers corresponding to the powers in the array list
            Random pick = new Random();//To randomely pick the powers for the int-array
            
            //do loop - Randomely pick and hold the powers until there is no discrepancy (matching numbers) 
            do
            {
                power[0] = pick.Next(0, 6);
                power[1] = pick.Next(0, 6);
                power[2] = pick.Next(0, 6);
            } while (power[0] == power[1] || power[0] == power[2] || power[1] == power[2]);
            //Assign the powers chosen to the superPowers array
            for (int count = 0; count < 3; count++)
            {
                superPowers[count] = superPowersList[power[count]];
            }
        }
        //Display the Superpowers
        public void showPowers()
        {
            Console.WriteLine("{0}'s Superpowers", this.name);
            Console.WriteLine("___________________________");
            foreach (string superPower in superPowers)//assign to and display each power in the superPowers array
            {
                Console.WriteLine("+{0}", superPower);
            }
        }
    }
}