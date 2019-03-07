using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.NameOfChild
{
   public class DefaultNameOfChildValidator : INameOfChildValidator
    {
        private string RegexPattern { get; set; }

        public DefaultNameOfChildValidator()
        {
            RegexPattern = @"[A-Z][a-z]+ [A-Z][a-z]+";
        }

        public bool Validate(string name)
        {
            if (ValidateForbiddenChars(name) && ValidateLength(name)&& ValidateFormat(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateForbiddenChars(string name)
        {
            if (Regex.Match(name,RegexPattern).Length < name.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateLength(string name)
        {
            if (name.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateFormat(string name)
        {
            if (Regex.IsMatch(name,RegexPattern))
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
