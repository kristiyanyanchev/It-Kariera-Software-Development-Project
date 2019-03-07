using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.Address
{
    public class DefaultAddressValidator : IAddressValidator
    {
        private string RegexPattern { get; set; }

        public DefaultAddressValidator()
        {
            RegexPattern = @"[A-Za-z]+[.][_A-Za-z]+[ -_:][0-9]+[_A-za-z]*";
        }

        public bool Validate(string address)
        {
            if (ValidateForbiddenChars(address) && ValidateLength(address) && ValidateWrongFormat(address))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateForbiddenChars(string address)
        {
            if (Regex.Match(address,RegexPattern).Length < address.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateWrongFormat(string address)
        {
            if (Regex.IsMatch(address,RegexPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string address)
        {
            if (address.Length < 6)
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
