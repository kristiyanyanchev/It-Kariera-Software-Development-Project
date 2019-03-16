using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.Money
{
    public class DefaultMoneyValidator : IMoneyValidator
    {
        private string RegexPattern { get; set; }

        public DefaultMoneyValidator()
        {
            RegexPattern = @"[0-9]+,[0-9]+";
        }

        public bool Validate(string money)
        {
            if (ValidateForbiddenChars(money) && ValidateFormat(money) && FirstSymbZero(money))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool FirstSymbZero(string ucn)
        {
            if(ucn[0]=='0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateForbiddenChars(string money)
        {
            if (Regex.Match(money, RegexPattern).Length < money.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateFormat(string money)
        {
            if (Regex.IsMatch(money, RegexPattern))
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
