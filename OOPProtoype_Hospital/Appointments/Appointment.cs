using OOPProtoype_Hospital.Patients;
using OOPProtoype_Hospital.Servants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProtoype_Hospital.Appointments
{
    public class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Patient.Name + " - "+ Doctor.Name +" - " + Doctor.Department.ToString() +" - " + Date.Date;
        }
    }


}
