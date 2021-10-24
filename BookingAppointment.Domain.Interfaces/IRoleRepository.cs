using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IRoleRepository<T> : IDisposable
        where T : Role
    {
        IEnumerable<Role> GetRoleList();
        Role GetRole(int id);
        void Create(Role role);
        void Update(Role role);
        void Delete(int id);
    }
}
