using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Football.Classes
{
    public abstract class Player
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public abstract string Shoot();
        public abstract string Pass();
    }
}
