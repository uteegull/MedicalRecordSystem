using MedicalRecordSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using MedicalRecordSystem.Data;

namespace MedicalRecordSystem.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _db;
        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateAppointment(Appointment appointment)
        {
            
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return true;
        }
        public List<Appointment> GetAppointments()
        {
            return _db.Appointments.ToList();
        }


        public bool ConfirmAppointment(Appointment objAppointment)
        {
            var ExistingAppointment = _db.Appointments.FirstOrDefault(x => x.Id == objAppointment.Id);
            if (ExistingAppointment != null)
            {
                ExistingAppointment.IsConfirmed = true;
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteAppointment(Appointment objAppointment)
        {
            var ExistingAppointment = _db.Appointments.FirstOrDefault(x => x.Id == objAppointment.Id);
            if (ExistingAppointment != null)
            {
                _db.Appointments.Remove(ExistingAppointment);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}

