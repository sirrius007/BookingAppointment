using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Business.Services
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepository<Doctor> _doctorRepository;
        public DoctorManager(IDoctorRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public void CreateDoctor(Doctor doctor)
        {
            _doctorRepository.Create(doctor);
        }

        public Doctor GetDoctor(int id)
        {
            return _doctorRepository.GetDoctor(id);
        }

        public bool IsExist(int id)
        {
            return _doctorRepository.IsExist(id);
        }

        public List<Doctor> GetDoctorList()
        {
            return _doctorRepository.GetDoctorList();
        }

        public void RemoveDoctor(int id)
        {
            _doctorRepository.Delete(id);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _doctorRepository.Update(doctor);
        }
    }
}
