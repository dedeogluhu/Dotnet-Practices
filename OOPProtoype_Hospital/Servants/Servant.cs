﻿using OOPProtoype_Hospital.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProtoype_Hospital.Servants
{
    public abstract class Servant
    {
        public string Name { get; set; }
        public Departments Department { get; set; }
        public abstract string Examine(Patient patient);
    }
}
