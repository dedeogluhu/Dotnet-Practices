using OOPPrototype_Football.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Football.Classes
{
    public class Striker : Player, IForward
    {

        public string PlayForward()
        {
            return "Striking the Goal";
        }

        public override string Shoot()
        {
            return "Shooting the Ball";
        }
    }
}
