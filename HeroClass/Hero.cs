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
            this.name = name;
            generateAbilities();//call generateAbilities Method within Constructor Method
        }
        private void generateAbilities()
        {
            Random points= new Random();
            strength = points.Next(1, 100);
            speed = points.Next(1, 100);
            health = points.Next(1, 100);

            Console.WriteLine("stats: health:{0}, strength:{1}, speed:{2}", health, strength, speed);
         }
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
        private int hitDamage()
        {
            int damage = 0;
            Random bonus = new Random();
            damage = this.strength * (bonus.Next(1, 6));
            return damage;
        }
    }

}
