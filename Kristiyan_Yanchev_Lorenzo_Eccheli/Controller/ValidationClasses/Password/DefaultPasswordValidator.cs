using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.Password
{
    public class DefaultPasswordValidator : IPasswordValidator
    {
        private string RegexPattern { get; set; }

        public DefaultPasswordValidator()
        {
            RegexPattern = "[A-Za-z0-9!@#$%^&*]+";
        }

        public bool Validate(string password)
        {
            if (ValidateLength(password) && ValidateForbiddenChars(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateForbiddenChars(string password)
        {
            if (Regex.Match(password,RegexPattern).Length < password.Length)
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
