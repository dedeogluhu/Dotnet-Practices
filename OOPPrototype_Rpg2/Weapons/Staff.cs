using OOPPrototype_Rpg2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Weapons
{
    public class Staff : Weapon, IMagical
    {
        public string CastSpell()
        {
            return "Casting Spell....";
        }
    }
}
