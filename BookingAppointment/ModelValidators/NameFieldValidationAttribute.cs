using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookingAppointment.ModelValidators
{
    public class NameFieldValidationAttribute : ValidationAttribute
    {
        private readonly int fieldLengthMin;
        private readonly int fieldLengthMax;
        private readonly bool containsDigits;
        public NameFieldValidationAttribute(int fieldLengthMin = 3, int fieldLengthMax = 30, bool containsDigits = false)
        {
            this.fieldLengthMin = fieldLengthMin;
            this.fieldLengthMax = fieldLengthMax;
            this.containsDigits = containsDigits;
        }
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string field = value.ToString();
                if (IsContainNumber(field) && containsDigits == false)
                {
                    this.ErrorMessage = "Текст поля не може містити цифр";
                    return false;
                }
                else if (IsLowerThanMinLength(field))
                {
                    this.ErrorMessage = $"Текст поля не може бути меншим за {fieldLengthMin} символів";
                    return false;
                }
                else if (IsHigherThanMaxLength(field))
                {
                    this.ErrorMessage = $"Текст поля не може бути більшим за {fieldLengthMax} символів";
                    return false;
                }
                else if (IsContainsSymbols(field))
                {
                    this.ErrorMessage = $"Текст поля не може містити сторонніх символів";
                    return false;
                }
                else if (IsStartFromSpace(field))
                {
                    this.ErrorMessage = $"Текст поля не може починатись з відступу";
                    return false;
                }
                return true;
            }
            return false;
        }
        private static bool IsContainNumber(string str)
        {
            Regex regex = new(@"[0-9]");
            return regex.IsMatch(str);
        }
        private bool IsHigherThanMaxLength(string str)
        {
            return str.Length > fieldLengthMax;
        }
        private bool IsLowerThanMinLength(string str)
        {
            return str.Length < fieldLengthMin;
        }
        private static bool IsContainsSymbols(string str)
        {
            Regex regex = new (@"[!@#$%^&*_+\=~`<>?:;/|]");
            return regex.IsMatch(str);
        }
        private static bool IsStartFromSpace(string str)
        {
            Regex regex = new (@"^\s");
            return regex.IsMatch(str);
        }
    }
}
