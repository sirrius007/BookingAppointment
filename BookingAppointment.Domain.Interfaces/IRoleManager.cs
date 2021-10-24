using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Domain.Interfaces
{
    public interface IRoleManager
    {
        List<Role> GetAllRoles();
        void CreateRole(Role role);
        Role GetRole(int id);
        void UpdateRole(Role role);
        void RemoveRole(Role role);
        Role GetRoleByRoleNameUser();
    }
}
