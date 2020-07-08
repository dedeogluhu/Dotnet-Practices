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
            if (Weapon is IBurstDamage)
            {
                return $"Player {Name} Bursts His Way Through";
            }
            else if (Weapon is IMachineGun)
            {
                IMachineGun a = (IMachineGun)Weapon;
                return "Ratatatatatatata";
            }
            else if (Weapon is ISuppressed)
            {
                return "Sssshhh";
            }
            else
            {
                return $"Player {Name} Shoots with {Weapon.Name}";
            }    
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

        public override string ToString()
        {
            return $"{Name}-{Health}-{Weapon.Name}";
        }
    }
}
