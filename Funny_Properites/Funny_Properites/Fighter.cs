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

        public String Name { get { return name; } }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public static string fight(Fighter fighter1, Fighter fighter2)
        {
            Fighter winner = new Fighter();
            Random rand = new Random();
            int hit1, hit2;
            do
            {
                hit1 = rand.Next(10);
                hit2 = rand.Next(10);
                if (hit1 > hit2)
                {
                    fighter2.health = fighter2.health - hit1;
                    Console.WriteLine("jas health: " + fighter2.health);
                }

                hit1 = rand.Next(10);
                hit2 = rand.Next(10);
                if (hit1 < hit2)
                {
                    fighter1.health = fighter1.health - hit2;
                }

                if (fighter1.health < 0)
                {
                    winner.name = fighter2.name;
                }

                if (fighter2.health < 0)
                {
                    winner.name = fighter1.name;
                }

            } while (fighter1.health > 0 && fighter2.health > 0);

            return winner.name;
        }

        //Random rand = new Random();

        //public static Fighter CreateFighter(Fighter fighter)
        //{
        //    Console.WriteLine("Create fighter 1:");
        //    Console.WriteLine("Fighter's 1 name:");
        //    fighter.name = Console.ReadLine();
        //    fighter.health = rand.Next(23);
        //    Console.WriteLine("{0} health = {1}", fighter.name, fighter.health);

        //    return new Fighter();
        //}
    }
}
