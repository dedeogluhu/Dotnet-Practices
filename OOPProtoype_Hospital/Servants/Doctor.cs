using OOPProtoype_Hospital.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProtoype_Hospital.Servants
{
    public class Doctor : Servant
    {
        

        public override string Examine(Patient patient)
        {
            return $"Examining Patient {patient.Name}";
        }

        public string Surgery()
        {
            return "Going to Surgery";
        }

        public override string ToString()
        {
            return Name + " - " + Department.ToString();
        }
    }
}
