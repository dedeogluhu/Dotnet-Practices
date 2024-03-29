﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Basketball
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Shoot()
        {
            return $"{Name} Shoots";
        }

        public string LayUp()
        {
            return $"{Name} Does a Layup";
        }

        public override string ToString()
        {
            return $"{Name} - {Age} - {GetType().Name}";
        }
    }
}
