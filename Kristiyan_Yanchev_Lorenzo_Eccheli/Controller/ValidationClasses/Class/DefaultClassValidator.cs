using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.Class
{
    public class DefaultClassValidator : IClassValidator
    {
        public string RegexPattern { get; set; }

        public DefaultClassValidator()
        {
            RegexPattern = @"[1-9]+[A-Z]";
        }

        public bool Validate(string @class)
        {
            if (ValidateLength(@class) && ValidateWrongFormat(@class))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string @class)
        {
            if (@class.Length < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private bool ValidateWrongFormat(string @class)
        {
            if (Regex.IsMatch(@class, RegexPattern))
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
