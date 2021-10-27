using BookingAppointment.Domain.Core;
using BookingAppointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ExtensionMethods
{
    public static class DoctorExtension
    {
        private static IndexDoctorDTO ToDoctorDTO(this Doctor doctor)
        {
            if (doctor == null)
                return null;
            IndexDoctorDTO doctorDTO = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                MiddleName = doctor.MiddleName,
                LastName = doctor.LastName,
                Phone = doctor.Phone,
                Email = doctor.Email,
            };
            return doctorDTO;
        }
        public static List<IndexDoctorDTO> ToListDoctorDTO(this List<Doctor> doctors)
        {
            if (doctors == null)
                return null;
            return doctors.Select(d => d.ToDoctorDTO()).ToList();
        }
        public static Doctor ToDoctor(this CreateDoctorDTO doctorDTO)
        {
            if (doctorDTO == null)
                return null;
            Doctor doctor = new()
            {
                FirstName = doctorDTO.FirstName,
                MiddleName = doctorDTO.MiddleName,
                LastName = doctorDTO.LastName,
                UserName = doctorDTO.UserName,
                Phone = doctorDTO.Phone,
                Email = doctorDTO.Email,
                Password = doctorDTO.Password,
            };
            return doctor;
        }
        public static DetailsDoctorDTO ToDoctorDetailsDTO(this Doctor doctor)
        {
            if (doctor == null)
                return null;
            DetailsDoctorDTO doctorDTO = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                MiddleName = doctor.MiddleName,
                LastName = doctor.LastName,
                UserName = doctor.UserName,
                Phone = doctor.Phone,
                Email = doctor.Email,
                Password = doctor.Password,
            };
            return doctorDTO;
        }
        public static EditDoctorDTO ToDoctorEditDTO(this Doctor doctor)
        {
            if (doctor == null)
                return null;
            EditDoctorDTO doctorDTO = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                MiddleName = doctor.MiddleName,
                LastName = doctor.LastName,
                UserName = doctor.UserName,
                Phone = doctor.Phone,
                Email = doctor.Email,
                Password = doctor.Password,
            };
            return doctorDTO;
        }
        public static Doctor ToDoctor(this EditDoctorDTO doctorDTO)
        {
            if (doctorDTO == null)
                return null;
            Doctor doctor = new()
            {
                Id = doctorDTO.Id,
                FirstName = doctorDTO.FirstName,
                MiddleName = doctorDTO.MiddleName,
                LastName = doctorDTO.LastName,
                UserName = doctorDTO.UserName,
                Phone = doctorDTO.Phone,
                Email = doctorDTO.Email,
                Password = doctorDTO.Password,
            };
            return doctor;
        }
        public static RemoveDoctorDTO ToDoctorRemoveDTO(this Doctor doctor)
        {
            if (doctor == null)
                return null;
            RemoveDoctorDTO doctorDTO = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                MiddleName = doctor.MiddleName,
                LastName = doctor.LastName,
                UserName = doctor.UserName,
                Phone = doctor.Phone,
                Email = doctor.Email,
                Password = doctor.Password,
            };
            return doctorDTO;
        }
    }
}
