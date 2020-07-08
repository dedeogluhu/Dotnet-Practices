using OOPPrototype_Fps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Fps.Classes
{
    class Pistol : Weapons, ISuppressed
    {
        public string PutSilencer()
        {
            return "Silencer Mounted";
        }
    }
}
