using BookingAppointment.Domain.Core;
using BookingAppointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ExtensionMethods
{
    public static class ScheduleExtension
    {
        private static IndexScheduleDTO ToScheduleDTO(this Schedule schedule)
        {
            if (schedule == null)
                return null;
            IndexScheduleDTO scheduleDTO = new()
            {
                Id = schedule.Id,
                Date = schedule.Date,
                StartTime = schedule.StartTime,
                EndTime = schedule.EndTime,
                DoctorId = schedule.DoctorId,
            };
            return scheduleDTO;
        }
        public static List<IndexScheduleDTO> ToListScheduleDTO(this List<Schedule> schedules)
        {
            List<IndexScheduleDTO> scheduleDTOs = schedules.Select(s => s.ToScheduleDTO()).ToList();
            return scheduleDTOs;
        }
    }
}
