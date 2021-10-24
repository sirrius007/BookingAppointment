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
        public string UserName { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
