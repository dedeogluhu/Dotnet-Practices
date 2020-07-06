using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgProject
{
    public class Enemy 
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public string EnemyType { get; set; }

        public Enemy()
        {
            
        }

        public void Attack(Player player)
        {
            player.GetDamage(Damage);
        }

        public void GetDamage(int damage)
        {
            Health -= damage + Armor;        
        }

    }
}
