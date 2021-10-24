using BookingAppointment.Domain.Core;
using BookingAppointment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppointment.Business.Services
{
    public class RoleManager : IRoleManager
    {
        private readonly IRoleRepository<Role> _roleRepository;
        public RoleManager(IRoleRepository<Role> roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public List<Role> GetAllRoles()
        {
            return _roleRepository.GetRoleList().ToList();
        }
        public void CreateRole(Role role)
        {
            _roleRepository.Create(role);
        }
        public Role GetRole(int id)
        {
            return _roleRepository.GetRole(id);
        }
        public void UpdateRole(Role role)
        {
            _roleRepository.Update(role);
        }
        public void RemoveRole(Role role)
        {
            _roleRepository.Delete(role.Id);
        }
        public Role GetRoleByRoleNameUser()
        {
            return _roleRepository.GetRoleList().FirstOrDefault(r => r.Name == "patient");
        }
    }
}
