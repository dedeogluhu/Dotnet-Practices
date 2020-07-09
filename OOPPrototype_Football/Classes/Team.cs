using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Football.Classes
{
    public class Team
    {
        public string Name { get; set; }
        public string Stadium { get; set; }
        public List<Player> Players { get; set; }
        public string Play(Team team)
        {
            return $"Playing a Game with {team}";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
