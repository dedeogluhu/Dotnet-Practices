using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgProject
{
    public class Player
    {
        public int Health  { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Score { get; set; }
        public bool IsAlive { get; set; }
        public Player()
        {
            Random random = new Random();

            Health = random.Next(200, 300);
            Armor = random.Next(40, 51);
            Damage = random.Next(30, 50);
            IsAlive = true;
            Score = 0;
        }

        

     

        public void Attack(Enemy enemy)
        {
            enemy.GetDamage(Damage);
        }

        public void GetDamage(int damage)
        {
            Health -= damage + Armor
                ; 
        }


    }
}
