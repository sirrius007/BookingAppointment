using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IDoctorManager
    {
        List<Doctor> GetDoctorList();
        void CreateDoctor(Doctor doctor);
        Doctor GetDoctor(int id);
        bool IsExist(int id);
        void UpdateDoctor(Doctor doctor);
        void RemoveDoctor(int id);
    }
}
