using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroClass
{
    class Hero
    {
        //Private Properties
        private int strength;
        private int speed;
        private int health;
        //Public Properties
        public string name;
        //Constructor Method
        public Hero(string name)
        {
            this.name = name;//public property (name) = equals the user input in the argument (string name)
            generateAbilities();//call generateAbilities Method within Constructor Method
        }
        //Randomely generates ability scores
        private void generateAbilities()
        {
            Random points= new Random();
            this.strength = points.Next(1, 100);
            this.speed = points.Next(1, 100);
            this.health = points.Next(1, 100);
        }
        //Fight Method - intiates combat: hits, misses, and calculating damage 
        public void fight() //fight Method calls hitAttempt
        {
            bool hit;
            hit = hitAttempt();//if true - hitAttempt Method calls hitDamage
 
            if (hit == true)
            {
                int damage = hitDamage();
                Console.WriteLine("{0} attacks with {1} damage!", this.name, damage);
            }
            else
            {
                Console.WriteLine("{0} misses!", this.name);
            }
        }
        //hitAttempt Method - player hits 20% of the time
        private bool hitAttempt()
        {
            bool hit = false;
            Random chance = new Random();
            int attack = chance.Next(1, 5);

            if (attack == 1)
            {
                hit = true;
            }
            else
            {
                hit = false;
            }
            return hit;
        }
        //hitDamage Method - calculate damage by strenght and multiplier (random: 1 to 6)
        private int hitDamage()
        {
            int damage = 0;
            Random bonus = new Random();
            damage = this.strength * (bonus.Next(1, 6));
            return damage;
        }
        //displays stats
        public void show()
        {
            Console.WriteLine("{0}'s Ability Scores", this.name);
            Console.WriteLine("____________________");
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("____________________");
        }
    }

}
