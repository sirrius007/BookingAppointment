using BookingAppointment.ModelValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class CreateDoctorDTO
    {
        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Не вказано ім'я лікаря")]
        [NameFieldValidation(2, 15, false)]
        public string FirstName { get; set; }
        [Display(Name = "По-батькові")]
        [NameFieldValidation(2, 15, false)]
        [Required(ErrorMessage = "Не вказано ім'я по батькові лікаря")]
        public string MiddleName { get; set; }
        [Display(Name = "Прізвище")]
        [NameFieldValidation(2, 15, false)]
        [Required(ErrorMessage = "Не вказано прізвище лікаря")]
        public string LastName { get; set; }
        [Display(Name = "Псевдонім/Логін")]
        [NameFieldValidation(2, 15, true)]
        [Required(ErrorMessage = "Не вказано псевдонім/логін лікаря")]
        public string UserName { get; set; }
        [Display(Name = "Номер мобільного телефону")]
        [Required(ErrorMessage = "Не вказано номер мобільного телефону лікаря")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Адреса електронної пошти")]
        [Required(ErrorMessage = "Не вказано адресу електронної пошти лікаря")]
        [EmailValidation]
        public string Email { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Не вказано пароль лікаря")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
