using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgProject
{
    class Elf : Enemy
    {
        public Elf()
        {
            EnemyType = "Elf";

            Random random = new Random();

            Health = random.Next(40,50);

            Armor = random.Next(20, 30);

            Damage = random.Next(20, 30);

            Console.WriteLine("An {3} has been spawned with {0} health {1} damage and {2} armor", Health, Damage, Armor, EnemyType);
        }
    }
}
