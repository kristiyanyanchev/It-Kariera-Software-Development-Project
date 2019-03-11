using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.ValidationCode
{
    interface IValidationCodeValidator
    {
        bool Validate(string code);
    }
}
