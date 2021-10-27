using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IDoctorRepository<T> : IDisposable
        where T : Doctor
    {
        List<Doctor> GetDoctorList();
        Doctor GetDoctor(int id);
        bool IsExist(int id);
        void Create(Doctor doctor);
        void Update(Doctor doctor);
        void Delete(int id);
    }
}
