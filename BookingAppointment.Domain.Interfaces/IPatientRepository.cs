using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IPatientRepository<T> : IDisposable
        where T : Patient
    {
        IEnumerable<Patient> GetPatientList();
        Patient GetPatient(int id);
        void Create(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
    }
}
