using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Business.Services
{
    public class ScheduleManager : IScheduleManager
    {
        private readonly IScheduleRepository<Schedule> _scheduleRepository;
        public ScheduleManager(IScheduleRepository<Schedule> scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public void CreateSchedule(Schedule schedule)
        {
            _scheduleRepository.Create(schedule);
        }

        public List<Schedule> GetAllSchedules()
        {
            return _scheduleRepository.GetScheduleList();
        }

        public Schedule GetSchedule(int id)
        {
            return _scheduleRepository.GetSchedule(id);
        }

        public void RemoveSchedule(int id)
        {
            _scheduleRepository.Delete(id);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            _scheduleRepository.Update(schedule);
        }
    }
}
