using OOPProtoype_Hospital.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProtoype_Hospital.Patients
{
    public class Patient
    {
        public string Name { get; set; }
        public Appointment Appointment { get; set; }

        public override string ToString()
        {
            if (Appointment == null)
            {
                return Name;
            }
            else
            {
                return Name +" - "+ Appointment.Doctor + " - "+ Appointment.Date;
            }

            
        }
    }
}
