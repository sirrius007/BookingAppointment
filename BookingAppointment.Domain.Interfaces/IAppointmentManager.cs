using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IAppointmentManager
    {
        List<Appointment> GetAllAppointments();
        void CreateAppointment(Appointment appointment);
        Appointment GetAppointment(int id);
        void UpdateAppointment(Appointment appointment);
        void RemoveAppointment(Appointment appointment);
    }
}
