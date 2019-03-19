using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.ValidationCode
{
    public class DefaultValidationCodeValidator : IValidationCodeValidator
    {
        private string RegexPattern { get; set; }

        public DefaultValidationCodeValidator()
        {
            RegexPattern = @"[A-Za-z0-9]+";
        }

        public bool Validate(string code)
        {
            if (Regex.Match(code,RegexPattern).Length < code.Length)
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
