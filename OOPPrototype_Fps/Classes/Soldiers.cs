using OOPPrototype_Fps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Fps.Classes
{
    public class Soldiers
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Weapons Weapon { get; set; }
        public string Shoot()
        {
            return $"Player {Name} Shoots with {Weapon.Name}";
        }

        public string Aim()
        {
            if (Weapon is IScoped)
            {
                IScoped scoped = (IScoped)Weapon;
                return scoped.ScopedAim();
            }
            else
            {
                return "Aimed";
            }
            
        }
    }
}
