using OOPPrototype_Rpg2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Characters
{
    public class Archer : Character
    {
        public override string Attack()
        {
            if (WeaponOwned is ILongRange)
            {
                ILongRange weapon = (ILongRange)WeaponOwned;
                return weapon.Shoot();
            }
            else
            {
                return $"Can't Shoot with {WeaponOwned.Name}";
            }
        }
    }
}
