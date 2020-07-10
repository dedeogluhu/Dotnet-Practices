using OOPProtoype_Hospital.Appointments;
using OOPProtoype_Hospital.Patients;
using OOPProtoype_Hospital.Servants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProtoype_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppointmentManager.Appointments = new List<Appointment>();

            Doctor doctor1 = new Doctor { Name = "Doctor1", Department = Departments.Dentistry };
            Doctor doctor2 = new Doctor { Name = "Doctor2", Department = Departments.InternalDiseases };

            Patient patient1 = new Patient { Name = "Patient1" };
            Patient patient2 = new Patient { Name = "Patien2" };

            Appointment appointment1 = new Appointment { Patient = patient1, Doctor = doctor1, Date = DateTime.Now };


            AppointmentManager.Add(appointment1);
            patient1.Appointment = appointment1;

            lbxAppointments.Items.Add(appointment1);
            lbxPatients.Items.Add(patient1);
            lbxPatients.Items.Add(patient2);
            cbxSelectPatient.Items.Add(patient1);
            cbxSelectPatient.Items.Add(patient2);
            cbxSelectDoctor.Items.Add(doctor1);
            cbxSelectDoctor.Items.Add(doctor2);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient { Name = tbxPatientName.Text };
            lbxPatients.Items.Add(patient);
            cbxSelectPatient.Items.Add(patient);
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment { 
                Patient = (Patient)cbxSelectPatient.SelectedItem, 
                Doctor = (Doctor)cbxSelectDoctor.SelectedItem,
                Date = dtpAppointmentDate.Value 
            };

            AppointmentManager.Add(appointment);
            lbxAppointments.Items.Add(appointment);

            Patient p = (Patient)cbxSelectPatient.SelectedItem;
            p.Appointment = appointment;

            lbxPatients.Items.Remove(p);
            lbxPatients.Items.Add(p);
        }
    }
}
