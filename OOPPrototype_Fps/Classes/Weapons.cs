using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Fps.Classes
{
    public abstract class Weapons
    {
        public string Name { get; set; }
        public int Ammo { get; set; }
        public int Damage { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
