using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IScheduleRepository<T> : IDisposable
        where T : Schedule
    {
        List<Schedule> GetScheduleList();
        Schedule GetSchedule(int id);
        void Create(Schedule doctor);
        void Update(Schedule doctor);
        void Delete(int id);
    }
}
