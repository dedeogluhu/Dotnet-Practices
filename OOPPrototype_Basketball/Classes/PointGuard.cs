using OOPPrototype_Basketball.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Basketball
{
    class PointGuard : Player, IThreePointShooter
    {
        public string ShootThreePoint()
        {
            return $"{Name} Shoots Three Pointer";
        }
    }
}
