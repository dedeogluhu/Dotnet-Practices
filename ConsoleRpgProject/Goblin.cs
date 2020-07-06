using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgProject
{
    class Goblin : Enemy
    {
        public Goblin()
        {
            EnemyType = "Goblin";

            Random random = new Random();

            Health = random.Next(40, 50);

            Armor = random.Next(5, 10);

            Damage = random.Next(10, 20);

            Console.WriteLine("An {3} has been spawned with {0} health {1} damage and {2} armor", Health, Damage, Armor, EnemyType);
        }
    }
}
