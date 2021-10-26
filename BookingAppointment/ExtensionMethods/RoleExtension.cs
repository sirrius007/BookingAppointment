using BookingAppointment.Domain.Core;
using BookingAppointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ExtensionMethods
{
    public static class RoleExtension
    {
        public static RoleDTO ToRoleDTO(this Role role)
        {
            if (role == null)
                return null;
            RoleDTO roleDTO = new()
            {
                Name = role.Name,
            };
            return roleDTO;
        }
    }
}
