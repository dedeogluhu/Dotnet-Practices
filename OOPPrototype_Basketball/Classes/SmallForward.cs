using OOPPrototype_Basketball.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Basketball.Classes
{
    public class SmallForward : Player, IThreePointShooter,IDunker
    {
        public string Dunk()
        {
            return $"{Name} Dunks";
        }

        public string ShootThreePoint()
        {
            return $"{Name} Shoots Three Pointer";
        }
    }
}
