using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controller.ValidationClasses.Username
{
    public class DefaultUsernameValidator : IUsernameValidator
    {
        private string RegexPattern { get; set; }

        public DefaultUsernameValidator()
        {
            RegexPattern = "[-.A-Za-z0-9_!@#$%^&*]+";
        }

        public bool Validate(string username)
        {
            if (ValidateForbiddenChars(username) && ValidateLength(username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string username)
        {
            if (username.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateForbiddenChars(string username)
        {
            if (Regex.Match(username, RegexPattern).Length < username.Length)
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
