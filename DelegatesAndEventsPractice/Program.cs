using DelegatesAndEventsPractice.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerOfTheGame displayPlayerOfTheGame = new DisplayPlayerOfTheGame();

            PlayerStats playerStats2 = new PlayerStats { Name = "Veli", Deaths = 5, FlagsCaptured = 5, Kills = 5 };
            PlayerStats playerStats1 = new PlayerStats { Name = "Ali", Deaths = 10, Kills = 10, FlagsCaptured = 10 };

            PlayerStats[] stats = new PlayerStats[] { playerStats1,playerStats2};



            displayPlayerOfTheGame.OnGameOver(stats);

            Console.ReadLine();
        }
    }
}
