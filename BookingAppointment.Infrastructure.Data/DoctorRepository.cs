using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class DoctorRepository : IDoctorRepository<Doctor>
    {
        private readonly BookingAppointmentContext _db;
        public DoctorRepository(BookingAppointmentContext db)
        {
            _db = db;
        }
        public List<Doctor> GetDoctorList()
        {
            return _db.Doctors.ToList();
        }
        public Doctor GetDoctor(int id)
        {
            return _db.Doctors.Find(id);
        }
        public bool IsExist(int id)
        {
            return _db.Doctors.Any(d => d.Id == id);
        }
        public void Create(Doctor doctor)
        {
            _db.Doctors.Add(doctor);
            _db.SaveChanges();
        }
        public void Update(Doctor doctor)
        {
            _db.Doctors.Update(doctor);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Doctors.Remove(GetDoctor(id));
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
