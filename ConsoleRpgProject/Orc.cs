using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgProject
{
    class Orc : Enemy
    {
        public Orc()
        {
            EnemyType = "Orc";

            Random random = new Random();

            Health = random.Next(70, 80);

            Armor = random.Next(30, 50);

            Damage = random.Next(20, 30);

            Console.WriteLine("An {3} has been spawned with {0} health {1} damage and {2} armor", Health, Damage, Armor, EnemyType);
        }
    }
}
