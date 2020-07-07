using OOPPrototype_Basketball.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Basketball.Classes
{
    class Team
    {
        public string Name { get; set; }
        public string Stadium { get; set; }
        public List<Player> Players { get; set; }
        public Conference WhichConference { get; set; }

    }
}
