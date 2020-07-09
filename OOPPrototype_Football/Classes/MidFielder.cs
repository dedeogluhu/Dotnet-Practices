using OOPPrototype_Football.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Football.Classes
{
    class MidFielder : Player, IGameMaker
    {
        public string CreatePosition()
        {
            return "Position Created";
        }

        public override string Shoot()
        {
            return "Bal Shot from Mid Field";
        }
    }
}
