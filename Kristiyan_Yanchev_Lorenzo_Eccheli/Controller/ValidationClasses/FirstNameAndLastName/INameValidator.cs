using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.FirstNameAndLastName
{
    interface INameValidator
    {
        bool Validate(string name);
    }
}
