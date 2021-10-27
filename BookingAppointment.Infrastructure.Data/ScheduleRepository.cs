using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Infrastructure.Data
{
    public class ScheduleRepository : IScheduleRepository<Schedule>
    {
        private readonly BookingAppointmentContext _db;
        public ScheduleRepository(BookingAppointmentContext db)
        {
            _db = db;
        }
        public List<Schedule> GetScheduleList()
        {
            return _db.Schedules.ToList();
        }
        public Schedule GetSchedule(int id)
        {
            return _db.Schedules.Find(id);
        }
        public void Create(Schedule schedule)
        {
            _db.Schedules.Add(schedule);
            _db.SaveChanges();
        }
        public void Update(Schedule schedule)
        {
            _db.Schedules.Update(schedule);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Schedules.Remove(GetSchedule(id));
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
