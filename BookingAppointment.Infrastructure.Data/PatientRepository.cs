using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class PatientRepository : IPatientRepository<Patient>
    {
        private readonly BookingAppointmentContext _db;
        public PatientRepository(BookingAppointmentContext bookingAppointmentContext)
        {
            _db = bookingAppointmentContext;
        }
        public IEnumerable<Patient> GetPatientList()
        {
            return _db.Patients.ToList();
        }
        public Patient GetPatient(int id)
        {
            return _db.Patients.Find(id);
        }
        public void Create(Patient patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
        }
        public void Update(Patient patient)
        {
            _db.Patients.Update(patient);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Patients.Remove(_db.Patients.Find(id));
            _db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
