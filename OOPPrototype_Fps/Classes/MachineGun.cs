using OOPPrototype_Fps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Fps.Classes
{
    class MachineGun : Weapons,IMachineGun
    {
        public string RapidFire()
        {
            return "Started Rapid Fire";
        }
    }
}
