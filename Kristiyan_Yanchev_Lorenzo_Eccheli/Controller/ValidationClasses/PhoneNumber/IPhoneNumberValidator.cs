using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.PhoneNumber
{
    interface IPhoneNumberValidator
    {
        bool Validate(string phoneNumber);
    }
}
