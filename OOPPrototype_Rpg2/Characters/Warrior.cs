using OOPPrototype_Rpg2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Characters
{
    public class Warrior : Character
    {
        public override string Attack()
        {
            if (WeaponOwned is ICloseRange)
            {
                ICloseRange weapon = (ICloseRange)WeaponOwned;
                return weapon.Slash();
            }
            else
            {
                return $"Can't Shoot with {WeaponOwned.Name}";
            }
        }
    }
}
