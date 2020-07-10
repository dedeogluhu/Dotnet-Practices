using OOPProtoype_Hospital.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProtoype_Hospital.Servants
{
    public class Nurse : Servant
    {
        public override string Examine(Patient patient)
        {
            return $"Helping Examining Patient {patient.Name}";
        }
    }
}
