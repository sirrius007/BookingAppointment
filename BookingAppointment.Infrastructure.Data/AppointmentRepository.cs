using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class AppointmentRepository : IAppointmentRepository<Appointment>
    {
        private readonly BookingAppointmentContext _db;
        public AppointmentRepository(BookingAppointmentContext bookingAppointmentContext)
        {
            _db = bookingAppointmentContext;
        }
        public IEnumerable<Appointment> GetAppointmentList()
        {
            return _db.Appointments.ToList();
        }
        public Appointment GetAppointment(int id)
        {
            return _db.Appointments.Find(id);
        }
        public void Create(Appointment appointment)
        {
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
        }
        public void Update(Appointment appointment)
        {
            _db.Appointments.Update(appointment);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Appointments.Remove(_db.Appointments.Find(id));
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
