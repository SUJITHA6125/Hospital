using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    namespace entity
    {
        public class Doctor
        {
            private int doctorId;
            private string firstName;
            private string lastName;
            private string specialization;
            private string contactNumber;

            // Default Constructor
            public Doctor() { }

            // Parametrized Constructor
            public Doctor(int doctorId, string firstName, string lastName, string specialization, string contactNumber)
            {
                this.doctorId = doctorId;
                this.firstName = firstName;
                this.lastName = lastName;
                this.specialization = specialization;
                this.contactNumber = contactNumber;
            }

            // Getters and Setters
            public int DoctorId { get => doctorId; set => doctorId = value; }
            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public string Specialization { get => specialization; set => specialization = value; }
            public string ContactNumber { get => contactNumber; set => contactNumber = value; }

            // ToString Method
            public override string ToString()
            {
                return $"Doctor ID: {doctorId}, Name: {firstName} {lastName}, Specialization: {specialization}, Contact: {contactNumber}";
            }
        }
    }


}
