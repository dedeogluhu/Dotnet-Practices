using OOPPrototype_Rpg2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Weapons
{
    public class Bow:Weapon,ILongRange
    {
        public int ArrowCount { get; set; }

        public string Shoot()
        {
            return "Shooting Arrows...";
        }
    }
}
