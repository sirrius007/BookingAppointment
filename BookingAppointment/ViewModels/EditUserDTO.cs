using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class EditUserDTO
    {
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }
        [Display(Name = "По-батькові")]
        public string MiddleName { get; set; }
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
        [Display(Name = "Дата народження")]
        public DateTime DateOfBorn { get; set; }
        [Display(Name = "Номер мобільного телефону")]
        public string Phone { get; set; }
        [Display(Name = "Адреса електронної пошти")]
        public string Email { get; set; }
    }
}
