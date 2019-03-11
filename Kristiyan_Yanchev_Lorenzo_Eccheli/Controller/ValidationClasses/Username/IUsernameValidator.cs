using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.Username
{
    interface IUsernameValidator
    {
        bool Validate(string username);
    }
}
