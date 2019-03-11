using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.Address
{
    interface IAddressValidator
    {
        bool Validate(string address);
    }
}
