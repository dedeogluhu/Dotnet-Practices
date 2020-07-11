using OOPPrototype_Rpg2.Spells;
using OOPPrototype_Rpg2.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Characters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public Weapon WeaponOwned { get; set; }
        public Spell SpellLearned { get; set; }

        public abstract string Attack();

        public override string ToString()
        {
            return $"{Name} - {GetType().Name} - {WeaponOwned.Name} - {SpellLearned.Name}";
        }
    }
}
