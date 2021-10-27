using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IScheduleManager
    {
        List<Schedule> GetAllSchedules();
        Schedule GetSchedule(int id);
        void CreateSchedule(Schedule schedule);
        void UpdateSchedule(Schedule schedule);
        void RemoveSchedule(int id);
    }
}
