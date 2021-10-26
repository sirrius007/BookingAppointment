using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookingAppointment.ModelValidators
{
    public class EmailValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var email = value as string;
            var regex = @"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-z]{2,4})";
            if (email != null)
            {
                if (!Regex.IsMatch(email, regex, RegexOptions.IgnoreCase))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Введена адреса електронної пошти не підпадає під загальний стандарт.";
        }
    }
}
