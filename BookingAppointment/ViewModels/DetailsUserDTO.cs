using BookingAppointment.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class DetailsUserDTO
    {
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }
        [Display(Name = "По-батькові")]
        public string MiddleName { get; set; }
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
        [Display(Name = "Дата народження")]
        public DateTime DateOfBorn { get; set; }
        [Display(Name = "Псевдонім/Логін")]
        public string UserName { get; set; }
        [Display(Name = "Номер мобільного телефону")]
        public string Phone { get; set; }
        [Display(Name = "Адреса електронної пошти")]
        public string Email { get; set; }
        [Display(Name = "Історія пацієнта")]
        public string PatientHistory { get; set; }
        public List<DetailsAppointmentDTO> Appointments { get; set; }
        [Display(Name = "Статус")]
        public RoleDTO Role { get; set; }
    }
}
