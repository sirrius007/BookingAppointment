using BookingAppointment.Domain.Core;
using BookingAppointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ExtensionMethods
{
    public static class UserExtension
    {
        public static User ToUser(this RegistrationUserDTO userDTO)
        {
            if (userDTO == null)
                return null;
            User user = new()
            {
                FirstName = userDTO.FirstName,
                MiddleName = userDTO.MiddleName,
                LastName = userDTO.LastName,
                UserName = userDTO.UserName,
                Phone = userDTO.Phone,
                Email = userDTO.Email,
                Password = userDTO.Password,
            };
            return user;
        }
    }
}