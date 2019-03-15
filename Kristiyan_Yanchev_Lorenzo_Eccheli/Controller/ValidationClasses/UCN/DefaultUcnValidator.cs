using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.UCN
{
    public class DefaultUcnValidator : IUcnValidator
    {
        private string RegexPattern { get; set; }

        public DefaultUcnValidator()
        {
            RegexPattern = @"[0-9]";
        }

        public bool Validate(string ucn)
        {
            if (ValidateForbiddenChars(ucn) && ValidateFormat(ucn) && ValidateLength(ucn))
            {
                return true;
            }
            else return false;
        }
        private bool ValidateForbiddenChars(string ucn)
        {
            if (Regex.Match(ucn, RegexPattern).Length < ucn.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private bool ValidateFormat(string ucn)
        {
            if (Regex.IsMatch(ucn, RegexPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string ucn)
        {
            if (ucn.Length == 10)
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
