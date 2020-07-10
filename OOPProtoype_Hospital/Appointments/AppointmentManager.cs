using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProtoype_Hospital.Appointments
{
    public static class AppointmentManager
    {
        public static List<Appointment> Appointments { get; set; }
        public static void Add(Appointment appointment)
        {
            Appointments.Add(appointment);
            
        }

        public static void Remove(Appointment appointment)
        {
            Appointments.Remove(appointment);
        }
    }
}
