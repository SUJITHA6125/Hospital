using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    namespace entity
    {
        public class Appointment
        {
            private int appointmentId;
            private int patientId;
            private int doctorId;
            private DateTime appointmentDate;
            private string description;

            // Default Constructor
            public Appointment() { }

            // Parametrized Constructor
            public Appointment(int appointmentId, int patientId, int doctorId, DateTime appointmentDate, string description)
            {
                this.appointmentId = appointmentId;
                this.patientId = patientId;
                this.doctorId = doctorId;
                this.appointmentDate = appointmentDate;
                this.description = description;
            }

            // Getters and Setters
            public int AppointmentId { get => appointmentId; set => appointmentId = value; }
            public int PatientId { get => patientId; set => patientId = value; }
            public int DoctorId { get => doctorId; set => doctorId = value; }
            public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
            public string Description { get => description; set => description = value; }

            // ToString Method
            public override string ToString()
            {
                return $"Appointment ID: {appointmentId}, Patient ID: {patientId}, Doctor ID: {doctorId}, Date: {appointmentDate}, Description: {description}";
            }
        }
    }
}
