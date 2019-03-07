using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.FirstNameAndLastName
{
    public class DefaultNameValidator : INameValidator
    {
        private string RegexPattern { get; set; }

        public DefaultNameValidator()
        {
            RegexPattern = "[A-Z][a-z]+";
        }

        public bool Validate(string name)
        {
            if (ValidateLength(name) && ValidateForbiddenChars(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateForbiddenChars(string name)
        {
            if (Regex.Match(name, RegexPattern).Length < name.Length)
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
