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
            generateAbilities();//call generateAbilities Method
        }
        private void generateAbilities()
        {
            Random random = new Random();
            int randomNumber = random.Next(100) + 1 ;

            Random random2 = new Random();
            int randomNumber2 = random.Next(100) + 1;

            Random random3 = new Random();
            int randomNumber3 = random.Next(100) + 1;

            strength = randomNumber;
            speed = randomNumber2;
            health = randomNumber3;

            Console.WriteLine("stats: health:{0}, strength:{1}, speed:{2}", health, strength, speed);

        }
    }

}
