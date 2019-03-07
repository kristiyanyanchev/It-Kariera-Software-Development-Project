using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.Email
{
    public class DefaultEmailValidator : IEmailValidator
    {
        private string RegexPattern { get; set; }

        public DefaultEmailValidator()
        {
            RegexPattern = @"[?><\|"";A-Za-z0-9.!#$%^&]+@[A-Za-z0-9]+[.][a-z]+";
        }

        public bool Validate(string email)
        {
            if ((ValidateForbiddenChars(email) && ValidateFormat(email)) && ValidateLength(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string email)
        {
            if (email.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateForbiddenChars(string email)
        {
            if (Regex.Match(email,RegexPattern).Length < email.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateFormat(string email)
        {
            if (Regex.IsMatch(email,RegexPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
