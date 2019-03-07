using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ValidationClasses.Password
{
    interface IPasswordValidator
    {
        bool Validate(string password);
    }
}
