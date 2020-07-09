﻿using OOPPrototype_Football.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Football.Classes
{
    class GoalKeeper : Player, IGoalKeeper
    {
        public string CatchBall()
        {
            return "Catching the Ball";
        }

        public override string Shoot()
        {
            return "Can't Shoot from Here";
        }
    }
}
