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
                DateOfBorn = userDTO.DateOfBorn,
                UserName = userDTO.UserName,
                Phone = userDTO.Phone,
                Email = userDTO.Email,
                Password = userDTO.Password,
            };
            return user;
        }
        public static User ToUser(this EditUserDTO userDTO)
        {
            if (userDTO == null)
                return null;
            User user = new()
            {
                FirstName = userDTO.FirstName,
                MiddleName = userDTO.MiddleName,
                LastName = userDTO.LastName,
                DateOfBorn = userDTO.DateOfBorn,
                Phone = userDTO.Phone,
                Email = userDTO.Email,
            };
            return user;
        }
        public static DetailsUserDTO ToUserDetailsDTO(this User user)
        {
            if (user == null)
                return null;
            DetailsUserDTO userDTO = new()
            {
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                DateOfBorn = user.DateOfBorn,
                UserName = user.UserName,
                Phone = user.Phone,
                Email = user.Email,
                Role = user.Role.ToRoleDTO(),
                Appointments = user.Appointments.Select(a => a.ToDetailsAppointmentDTO()).ToList(),
            };
            return userDTO;
        }
        public static EditUserDTO ToUserEditDTO(this User user)
        {
            if (user == null)
                return null;
            EditUserDTO userDTO = new()
            {
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                DateOfBorn = user.DateOfBorn,
                Phone = user.Phone,
                Email = user.Email,
                
            };
            return userDTO;
        }
    }
}