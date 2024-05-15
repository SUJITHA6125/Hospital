﻿
using Hospital.Dao.dao;
using Hospital.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Dao
{
  
        namespace dao
    {
        public interface IHospitalService
        {
            Appointment GetAppointmentById(int appointmentId);
            List<Appointment> GetAppointmentsForPatient(int patientId);
            List<Appointment> GetAppointmentsForDoctor(int doctorId);
            bool ScheduleAppointment(Appointment appointment);
            bool UpdateAppointment(Appointment appointment);
            bool CancelAppointment(int appointmentId);
        }
    }

}



