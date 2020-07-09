using OOPPrototype_Football.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Football.Classes
{
    class Defender : Player, IDefense
    {
        public string Defend()
        {
            return "Defending the Goal";
        }

        public override string Shoot()
        {
            return "Shooting from Far Away";
        }
    }
}
