using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Spells
{
    public abstract class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int ManaNeeded { get; set; }
        public abstract string Cast();

        public override string ToString()
        {
            return Name;
        }
    }
}
