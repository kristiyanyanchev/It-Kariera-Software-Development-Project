using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.PhoneNumber
{
    public class DefaultPhoneNumberValidator : IPhoneNumberValidator
    {
        private string RegexPattern { get; set; }

        public DefaultPhoneNumberValidator()
        {
            RegexPattern = @"[0-9]+";
        }

        public bool Validate(string phoneNumber)
        {
            if (ValidateLength(phoneNumber) && ValidateForbiddenChars(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string number)
        {
            if (number.Length != 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateForbiddenChars(string number)
        {
            if (Regex.Match(number,RegexPattern).Length < number.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
