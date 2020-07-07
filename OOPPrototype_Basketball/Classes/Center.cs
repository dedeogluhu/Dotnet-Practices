using OOPPrototype_Basketball.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Basketball.Classes
{
    class Center:Player,IRebaunder,IDunker
    {
        public string Dunk()
        {
            return $"{Name} Dunks";
        }

        public string Rebaund()
        {
            return $"{Name} Gets a Rebaund";
        }
    }
}
