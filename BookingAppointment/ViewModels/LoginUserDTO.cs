using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAppointment.ViewModels
{
    public class LoginUserDTO
    {
        [Display(Name = "Логін/Псевдонім")]
        [Required(ErrorMessage = "Не вказано псевдонім/логін користувача")]
        public string UserName { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Не вказано пароль користувача")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
