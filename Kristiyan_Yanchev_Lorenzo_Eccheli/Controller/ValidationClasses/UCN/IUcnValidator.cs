using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.ValidationClasses.UCN
{
    public interface IUcnValidator
    {
        bool Validate(string ucn);
    }
}
