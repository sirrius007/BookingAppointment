using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IAppointmentRepository<T> : IDisposable
        where T : Appointment
    {
        IEnumerable<Appointment> GetAppointmentList();
        Appointment GetAppointment(int id);
        void Create(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(int id);
    }
}
