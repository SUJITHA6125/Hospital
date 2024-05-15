using Hospital.Models.entity;
using Hospital.Dao.dao;
using System;
using System.Collections.Generic;
using Hospital.exceptions.myexceptions;
using System.Data.SqlClient;
using System.Data;
using Hospital.util.util;


namespace mainmod
{
    class MainModule
    {
        static void Main(string[] args)
        {
            // Create an instance of the service implementation
            IHospitalService hospitalService = new HospitalServiceImpl();

            try
            {
                // Get appointment by ID
                Appointment appointment = hospitalService.GetAppointmentById(1);
                Console.WriteLine("Appointment by ID:");
                Console.WriteLine(appointment);

                // Get appointments for a patient
                List<Appointment> patientAppointments = hospitalService.GetAppointmentsForPatient(1001);
                Console.WriteLine("\nAppointments for Patient:");
                foreach (var app in patientAppointments)
                {
                    Console.WriteLine(app);
                }

                // Get appointments for a doctor
                List<Appointment> doctorAppointments = hospitalService.GetAppointmentsForDoctor(2001);
                Console.WriteLine("\nAppointments for Doctor:");
                foreach (var app in doctorAppointments)
                {
                    Console.WriteLine(app);
                }

                // Schedule a new appointment
                Appointment newAppointment = new Appointment(3, 1001, 3001, DateTime.Now.AddDays(21), "Follow-up test");
                bool isScheduled = hospitalService.ScheduleAppointment(newAppointment);
                if (isScheduled)
                {
                    Console.WriteLine("\nNew appointment scheduled successfully:");
                    Console.WriteLine(newAppointment);
                }

                // Update an appointment
                Appointment updatedAppointment = new Appointment(2, 1001, 3001, DateTime.Now.AddDays(14), "Lab test (updated)");
                bool isUpdated = hospitalService.UpdateAppointment(updatedAppointment);
                if (isUpdated)
                {
                    Console.WriteLine("\nAppointment updated successfully:");
                    Console.WriteLine(updatedAppointment);
                }

                // Cancel an appointment
                int appointmentIdToCancel = 1;
                bool isCancelled = hospitalService.CancelAppointment(appointmentIdToCancel);
                if (isCancelled)
                {
                    Console.WriteLine($"\nAppointment with ID {appointmentIdToCancel} canceled successfully.");
                }

                // Example SQL query using DBConnection to retrieve data related to users
                using (IDbConnection connection = DBConnection.GetConnection())
                {
                    string sqlQuery = "SELECT * FROM HOSPITAL";
                    using (IDbCommand command = new SqlCommand(sqlQuery, (SqlConnection)connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("\nUsers:");
                            while (reader.Read())
                            {
                                int userId = (int)reader["UserId"];
                                string username = reader["Username"].ToString();
                                string email = reader["Email"].ToString();
                                Console.WriteLine($"User ID: {userId}, Username: {username}, Email: {email}");
                            }
                        }
                    }
                }
            }
            catch (PatientNumberNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
