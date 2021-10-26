using BookingAppointment.Domain.Core;
using BookingAppointment.ModelValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class RegistrationUserDTO
    {
        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Не вказано ім'я користувача")]
        [NameFieldValidation(2, 15, false)]
        public string FirstName { get; set; }
        [Display(Name = "По-батькові")]
        [NameFieldValidation(2, 15, false)]
        [Required(ErrorMessage = "Не вказано ім'я по батькові користувача")]
        public string MiddleName { get; set; }
        [Display(Name = "Прізвище")]
        [NameFieldValidation(2, 15, false)]
        [Required(ErrorMessage = "Не вказано прізвище користувача")]
        public string LastName { get; set; }
        [Display(Name = "Дата народження")]
        [Required(ErrorMessage = "Не вказано дату народження")]
        [DataType(DataType.Date)]
        public DateTime DateOfBorn { get; set; } 
        [Display(Name = "Псевдонім/Логін")]
        [NameFieldValidation(2, 15, true)]
        [Required(ErrorMessage = "Не вказано псевдонім/логін користувача")]
        public string UserName { get; set; }
        [Display(Name = "Номер мобільного телефону")]
        [Required(ErrorMessage = "Не вказано номер мобільного телефону користувача")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Адреса електронної пошти")]
        [Required(ErrorMessage = "Не вказано адресу електронної пошти користувача")]
        [EmailValidation]
        public string Email { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Не вказано пароль користувача")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Повторно введіть пароль")]
        [Required(ErrorMessage = "Повторно не вказано пароль користувача")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Невірно введений пароль")]
        public string ConfirmPassword { get; set; }
    }
}
