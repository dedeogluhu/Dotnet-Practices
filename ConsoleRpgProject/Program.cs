using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgProject
{
    class Program
    {
        public bool IsDead { get; set; }

        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Welcome to XRPG");

            Player player = new Player();

            Console.WriteLine("You have {0} health {1} armor {2} damage {3}score", player.Health, player.Armor, player.Damage, player.Score);

            StartFighting(player);

        }

        private static void StartFighting(Player player )
        {
            Random random = new Random();

            Console.ReadLine();


            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
            {
                Elf elf = new Elf();

                Fight(player, elf);
            }
            else if (randomNumber == 2)
            {
                Orc orc = new Orc();

                Fight(player, orc);
            }
            else if (randomNumber == 3)
            {
                Goblin goblin = new Goblin();

                Fight(player, goblin);
            }
        }

        private static void Fight(Player player, Enemy enemy)
        {
            while (player.IsAlive)
            {
                player.Attack(enemy);
                Console.WriteLine("Enemy has {0} Health left", enemy.Health);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine("Enemy Died");

                    player.Score += 10;

                    StartFighting(player);
                }
                enemy.Attack(player);
                Console.WriteLine("Player has {0} health left",player.Health);
                if (player.Health <= 0)
                {
                    OnPlayerDeath(player);
                }
                Console.ReadKey();
            }
            
        }

        public static void OnPlayerDeath(Player player)
        {
            player.IsAlive = false;

            Console.WriteLine("Game Over");

            Console.WriteLine("Your Score is {0}", player.Score);

            Console.ReadLine();

            Environment.Exit(0);

        }
    }
}
