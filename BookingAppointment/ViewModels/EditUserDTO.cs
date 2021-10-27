using BookingAppointment.ModelValidators;
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
        [Required(ErrorMessage = "Не вказано ім'я користувача")]
        [NameFieldValidation(2, 15, false)]
        public string FirstName { get; set; }
        [Display(Name = "По-батькові")]
        [Required(ErrorMessage = "Не вказано ім'я користувача")]
        [NameFieldValidation(2, 15, false)]
        public string MiddleName { get; set; }
        [Display(Name = "Прізвище")]
        [Required(ErrorMessage = "Не вказано ім'я користувача")]
        [NameFieldValidation(2, 15, false)]
        public string LastName { get; set; }
        [Display(Name = "Дата народження")]
        [Required(ErrorMessage = "Не вказано дату народження")]
        [DataType(DataType.Date)]
        public DateTime DateOfBorn { get; set; }
        [Display(Name = "Номер мобільного телефону")]
        [Required(ErrorMessage = "Не вказано номер мобільного телефону користувача")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Адреса електронної пошти")]
        [Required(ErrorMessage = "Не вказано адресу електронної пошти користувача")]
        [EmailValidation]
        public string Email { get; set; }
    }
}
