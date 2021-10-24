using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Business.Services
{
    public class AppointmentManager : IAppointmentManager
    {
        private readonly IAppointmentRepository<Appointment> _appointmentRepository;
        public AppointmentManager(IAppointmentRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public List<Appointment> GetAllAppointments()
        {
            return _appointmentRepository.GetAppointmentList().ToList();
        }
        public void CreateAppointment(Appointment appointment)
        {
            _appointmentRepository.Create(appointment);
        }
        public Appointment GetAppointment(int id)
        {
            return _appointmentRepository.GetAppointment(id);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _appointmentRepository.Update(appointment);
        }

        public void RemoveAppointment(Appointment appointment)
        {
            _appointmentRepository.Delete(appointment.Id);
        }
    }
}
