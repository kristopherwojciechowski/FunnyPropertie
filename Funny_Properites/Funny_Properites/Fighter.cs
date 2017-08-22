using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    class Fighter
    {
        public String name;
        public int health;

        public Fighter() { }
        public Fighter(String Name, int Health)
        {
            this.name = Name;
            this.health = Health;
        }

        // set accesors: GET & SET

        public static string fight(Fighter name1, Fighter name2)
        {
            Fighter winner = new Fighter();
            Random rand = new Random();

            int hit1, hit2;
            while (name1.health > 0 | name2.health > 0)
            {
                hit1 = rand.Next(10);
                hit2 = rand.Next(10);
                if (hit1 > hit2)
                {
                    name2.health = name2.health - hit1;
                }

                hit1 = rand.Next(10);
                hit2 = rand.Next(10);
                if (hit1 < hit2)
                {
                    name1.health = name1.health - hit2;
                }

                if (name1.health < 0)
                {
                    winner.name = name2.name;
                } else
                {
                    winner.name = name1.name;
                }
            }
            return winner.name;
        } 
    }
}
